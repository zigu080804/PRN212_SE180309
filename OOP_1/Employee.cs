using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    public class Employee
    {
        #region nhóm các thuộc tính của Employee
        private int id;
        private string id_card;
        private String name;
        private String email;
        private String phone;
        #endregion

        public Employee() 
        {
            this.id = 1;
            IdCard = "00000";
            name = "Test";
            email = "Test";
            phone = "Test";
        }
        public Employee(int id, string id_card, string name, string email, string phone)
        {
            this.id = id;
            this.id_card = id_card;
            this.name = name;
            this.email = email;
            this.phone = phone;
            
        }

        
        

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public String IdCard
        {
            get { return id_card; }
            set { id_card = value; }
        }
        public String Email
        {
            get { return email; }   
            set { email = value; }
        }
        public String Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        
        public void printInfor()
        {
            string msg = $"{Id}\t{id_card}\t{name}\t{email}\t{Phone}";
            Console.WriteLine(msg);
        }
        public override String ToString()
        {
            string msg = $"{Id}\t{id_card}\t{name}\t{email}\t{Phone}";
            return msg;
        }
    }
}
