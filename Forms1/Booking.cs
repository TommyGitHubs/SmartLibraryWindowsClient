using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Net;
using System.Drawing.Imaging;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Smart_Library.Forms1
{
    public partial class Booking : Form
    {
        public DataTable dt = new DataTable();
        public DataTable dtbook = new DataTable();
        public DataTable dtbookinfo = new DataTable();
        public string CellValue, CellValueStudentid;

        public static string mapbook;
        string str1, str2, str3, lockerposition, KeyName, idbook;
        public Booking()
        {
            InitializeComponent();
        }
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "cN3BdjyhiY7jT0lxjv8AjBJ0Eh59O2jlWdFp3q2n",
            BasePath = "https://teoshop-7e4a7.firebaseio.com/"
        };
        IFirebaseClient client;

        private void Booking_Load(object sender, EventArgs e)
        {
            LoadTheme();
            
                client = new FireSharp.FirebaseClient(config);
                
                dt.Columns.Add("Student ID");
                dataGridView2.DataSource = dt;

                dtbook.Columns.Add("Book ID");
                dataGridViewBook.DataSource = dtbook;

                dtbookinfo.Columns.Add("ID");
                dtbookinfo.Columns.Add("Name");
                dtbookinfo.Columns.Add("Author");
                dataGridViewBookInput.DataSource = dtbookinfo;

                export();
            
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

                }
            }

            label1.ForeColor = ThemeColor.SecondaryColor;
            label2.ForeColor = ThemeColor.PrimaryColor;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            export();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           if(DateTime.Now.ToString("HH:mm") == "16:50")
            {
                FirebaseResponse response = client.Get("BookingRequest/Request/");
                Dictionary<string, Request> getStatus = response.ResultAs<Dictionary<string, Request>>();
                foreach (var get in getStatus)
                {
                    if(get.Value.status == "off")
                    {
                        // Clear Locker number, lockerpw, studentid
                        //FirebaseResponse response1 = client.Get("locker" + get.Key);
                        //Dictionary<string, LockerClass> getLocker = response.ResultAs<Dictionary<string, LockerClass>>();
                        //foreach (var get1 in getLocker)
                        //{
                        //    get1.Value.pw = "";
                        //    get1.Value.Studentid = "";
                        //}
                        
                        var lockerinfo = new Data
                        {
                            lockernumber = "",
                            lockerpw = "",
                        };
                        FirebaseResponse response2 = client.Update(@"Users/" + get.Key + "@student,hcmute,edu,vn/borrow",lockerinfo);

                        // Delete borrow book request
                        FirebaseResponse response1 = client.Get("BookingRequest/Request/"  + get.Key + "/Bookfake/");
                        Dictionary<string, Request> getBookfake = response1.ResultAs<Dictionary<string, Request>>();
                        foreach(var get2 in getBookfake)
                        {
                            // tach id sach
                            int id = get2.Key.IndexOf("id");
                            str1 = get2.Key.Substring(0, 3);
                            str2 = get2.Key.Substring(3, id - 3); // If Hx get 2 character, Hxx get 3 character, Hxxx get 4 character ...
                            str3 = get2.Key.Substring(id + 2, 3); // Start get id after 'id'
                            FirebaseResponse response5 = client.Delete("BookingRequest/Request/" + get.Key);
                            FirebaseResponse response7 = client.Delete("Users/" + get.Key + "@student,hcmute,edu,vn/borrow/"+ get2.Key);
                        }
                        FirebaseResponse response6 = client.Update(str1+"/"+str2+"/id/"+str3,"off");                                             
                    }
                }
            }
        }

        private void txtbookID2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int id = txtbookID2.Text.IndexOf("id");
                str1 = txtbookID2.Text.Substring(0, 3);
                str2 = txtbookID2.Text.Substring(3, id - 3); // If Hx get 2 character, Hxx get 3 character, Hxxx get 4 character ...
                str3 = txtbookID2.Text.Substring(id + 2, 3); // Start get id after 'id'  

                // Lay dia chi cua sach, Get product_name, product_tacgia, POPH1/
                FirebaseResponse response = client.Get(str1 + "/" + str2);
                BookInfo result = response.ResultAs<BookInfo>();

                DataRow row3 = dtbookinfo.NewRow(); // Row cua BookInfo
                                                    //row["ID"] = result.id;
                row3["Name"] = result.product_name;
                row3["Author"] = result.product_tacgia;
                row3["ID"] = txtbookID2.Text;
                dtbookinfo.Rows.Add(row3);


                txtbookID2.Text = "";
                // lay id POPH1id001/id
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            BookingStudentBook();
        }
        /*
         * State 1: Random Locker Password
         * LockerInformation[4,3] : [locker, student id, password]
         * *************************[   0  ,     1     ,    2    ]
         * byte rowlocker : increase row LockerInformation
         * string RLockerPassword : Random Password tam thoi
         * public string CellValueStudentid : id Student da chon
         * 
         * State 2: Switch status BookingRequest + add id book in BookFake
         * idbook : id of book in dataGridViewBookInput
         * 
         * State 3: Add list book into Borrow of User(A) + suplite locker and password to student (B)
         * string IDBookarray[count] : The id of book in list booking
         * LockerInformation[loop1, 2] : Password
         * LockerInformation[loop1, 0] : Locker number
         *
         * State 4: Change status book "onn"
         * string IDBookarray[count] : The id of book in list booking
         */
        private void BookingStudentBook()
        {
            // State 1
            string RLockerPassword;
            string[,] LockerInformation = new string[4, 3];
            FirebaseResponse response = client.Get("locker/");
            IDictionary<string, LockerClass> getLocker = response.ResultAs<IDictionary<string, LockerClass>>();

            byte rowlocker = 0; // So nguyen duong 0-255

 
            foreach (var get in getLocker)
            {
                // Moi lan trong for add Key. 
                LockerInformation[rowlocker, 0] = get.Key;
                LockerInformation[rowlocker, 1] = get.Value.Studentid;
                LockerInformation[rowlocker, 2] = get.Value.pw;
                //MessageBox.Show("LockerInfor name: "+ LockerInformation[rowlocker,0] + "\nLocker student id: " + LockerInformation[rowlocker,1] + "\nLocker student id: " + LockerInformation[rowlocker,2]);
                rowlocker++;
                //MessageBox.Show("RowLocker: " + rowlocker.ToString());
            }
            
            // find empty password
            for (byte loop1 = 0; loop1 < rowlocker; loop1++)
            {
                if (LockerInformation[loop1, 2] == "")
                {
                    //MessageBox.Show("The empty password at: " + LockerInformation[loop1,0]);
                    // Random password
                    Random random = new Random();
                    RLockerPassword = random.Next(100, 999).ToString();
                    //LockerInformation[loop1, 2] = random.Next(100, 999).ToString();
                    //MessageBox.Show("Password is random: " + LockerInformation[loop1,2]);
                    // Replace password?
                    for(byte loop2 = 0; loop2 < rowlocker; loop2++)
                    {
                        if(RLockerPassword == LockerInformation[loop2,2])
                        {
                            loop2 = 0;
                            RLockerPassword = random.Next(100, 999).ToString();
                        }
                    }
                    // add password in locker
                    LockerInformation[loop1, 2] = RLockerPassword;
                    //MessageBox.Show("The password is: " + RLockerPassword + "\nat: " + LockerInformation[loop1, 0]);
                    LockerInformation[loop1, 1] = CellValueStudentid;
                    var UpdateLocker = new LockerClass
                    {
                        Studentid = CellValueStudentid, // Student id in here
                        pw = LockerInformation[loop1, 2]
                    };
                    FirebaseResponse response1 = client.Set("locker/" + LockerInformation[loop1, 0], UpdateLocker);


            // State 2:
                    Dictionary<string, string> bookfake = new Dictionary<string, string>();
                    string[] IDBookarray = new string[20];
                    byte count = 0;
                    try
                    {                      
                        while (true)
                        {
                            idbook = dataGridViewBookInput.Rows[count].Cells[0].Value.ToString();
                            IDBookarray[count] = idbook;
                            count++;
                            //MessageBox.Show(idbook);  

                            // Add ID book in BookFake
                            var BookFake = new Data
                            {
                                id = idbook                                
                            };
                                FirebaseResponse response2 =  client.Update("BookingRequest/Request/" + CellValueStudentid + "/Bookfake/" + idbook,BookFake);                              
                        }

                    }
                    catch
                    {
                        // Set Status
                        FirebaseResponse response3 =  client.Set("BookingRequest/Request/" + CellValueStudentid + "/status", "off");
                        //MessageBox.Show("Done");
                    }


            // State 3: (A)
                /*
                for( byte numbook = 0; numbook < count; numbook++)
                {
                    var studentBorrowBook = new Data
                    {
                        mfg = DateTime.Now.ToString("dd/MM/yyyy"),
                        exp = "20/10/2020",
                        id = IDBookarray[numbook],
                    };
                    FirebaseResponse response5 =  client.Set(@"Users/" + CellValueStudentid + "@student,hcmute,edu,vn/borrow/sach/" + IDBookarray[numbook], studentBorrowBook);
                }
                */
            // State 3: (B)
                var lockerInfo = new Data
                {
                    lockernumber = LockerInformation[loop1, 0],
                    lockerpw = LockerInformation[loop1, 2],
                };
                FirebaseResponse response6 =  client.Update(@"Users/" + CellValueStudentid + "@student,hcmute,edu,vn/borrow/", lockerInfo);


            // State 4:
            // Tao duong dan vao sach
                for( byte numbook = 0; numbook < count; numbook++)
                {
                    int id = IDBookarray[numbook].IndexOf("id");
                    str1 = IDBookarray[numbook].Substring(0, 3);
                    str2 = IDBookarray[numbook].Substring(3, id - 3); // If Hx get 2 character, Hxx get 3 character, Hxxx get 4 character ...
                    str3 = IDBookarray[numbook].Substring(id + 2, 3); // Start get id after 'id'
                    FirebaseResponse response7 =  client.Set(str1 + "/" + str2 + "/id/" + str3 + "/status", "onn"); // status book 
                    int quantity = 0;
                    FirebaseResponse response8 = client.Get(str1 + "/" + str2);
                    CategoryBook product_Soluong = response8.ResultAs<CategoryBook>();
                    quantity = product_Soluong.product_soluong - 1;
                    //MessageBox.Show(count.ToString());
                    FirebaseResponse response9 = client.Set(str1 + "/" + str2 + "/product_soluong", quantity);
                }
                    MessageBox.Show(LockerInformation[loop1, 0]);
                    break;
                }
                //if(i == (rowlocker -1) ) MessageBox.Show("All locker is used.\nRowlocker: "+ (rowlocker-1).ToString() + "\ni: "+i.ToString());
                if (loop1 == (rowlocker - 1)) MessageBox.Show("All locker is used");
            }
            

        }

        private void export()
        {
            FirebaseResponse response2 = client.Get("BookingRequest/Request/");
            Dictionary<string, Request> getStatus2 = response2.ResultAs<Dictionary<string, Request>>();

            //MessageBox.Show(path);
            // Status is end off end Key in Request
            dt.Rows.Clear();
            foreach (var get in getStatus2)
            {
                // if status "on" => Retrieve
                if (get.Value.status == "on")
                {
                    //MessageBox.Show(get.Key);
                    DataRow row = dt.NewRow();
                    row["Student ID"] = get.Key;
                    dt.Rows.Add(row);
                }
            }
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if(row.Selected)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            int index = cell.ColumnIndex;
                            if (index == 0)
                            {
                                //MessageBox.Show(cell.Value.ToString());
                                // Student id
                                CellValueStudentid = cell.Value.ToString();
                                // Do in there
                                try
                                {                                    
                                        dtbook.Rows.Clear();
                                        FirebaseResponse response = client.Get("BookingRequest/Request/" + CellValueStudentid + "/BookList/");
                                        Dictionary<string, Request> getStudents = response.ResultAs<Dictionary<string, Request>>();

                                        foreach (var get in getStudents)
                                        {
                                            
                                            // add id book
                                            DataRow bookrow = dtbook.NewRow();
                                            bookrow["Book ID"] = get.Key;
                                            dtbook.Rows.Add(bookrow);
                                        }                                                                        
                                }
                                catch
                                {
                                    MessageBox.Show("Please try again2.");
                                }
                            }
                        }
                    }
                }
                                              
            }
            catch
            {
                MessageBox.Show("Please try again.");
            }
        }

        private void txtBookId_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dataGridViewBook_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewBook.Rows)
            {
                if (row.Selected)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        int index = cell.ColumnIndex;
                        if (index == 0)
                        {
                            //MessageBox.Show(cell.Value.ToString());
                            CellValue = cell.Value.ToString();

                            string idbook = CellValue; // Get book id
                            //MessageBox.Show(idbook);
                        
                            FirebaseResponse response = client.Get(idbook.Substring(0, 3) + "/" + idbook.Substring(3));
                            ClassMap map = response.ResultAs<ClassMap>();
                            //MessageBox.Show(map.map);
                            mapbook = map.map;

                            FormMap Random = new FormMap();
                            Random.ShowDialog();
                        }
                    }
                }
            }
        }
 

        private void Export2()
        {
            int num2 = 0;
            Random random = new Random();
            num2 = random.Next(100, 999); // Ket thuc
                                          // Bo ham vao day
            FirebaseResponse response1 = client.Set("locker/" + KeyName + "/pw", Convert.ToString(num2));
            FirebaseResponse response4 = client.Set("locker/" + KeyName + "/Studentid", CellValueStudentid);
            //MessageBox.Show(Convert.ToString(get.Key.Count()));  
            var lockerinfo = new Data
            {
                lockernumber = KeyName,
                lockerpw = Convert.ToString(num2),
            };
            lockerposition = lockerinfo.lockernumber;
            FirebaseResponse response7 = client.Update(@"Users/" + CellValueStudentid + "@student,hcmute,edu,vn/borrow/", lockerinfo);
            FirebaseResponse response3 = client.Set(str1 + "/" + str2 + "/id/" + str3 + "/status", "onn");   // Status book
            FirebaseResponse response6 = client.Set("BookingRequest/Request/" + CellValueStudentid + "/status", "off");    // Status Request
        }
    }
}
