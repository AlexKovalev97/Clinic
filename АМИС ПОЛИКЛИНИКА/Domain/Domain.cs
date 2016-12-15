using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Key {
        private int id;
        public Key(int gId)
        {id = gId;}

        public int Id{
            get { return id; }
            set { id = value; }}
    }

    public class Person:Key
    {
        private string fio;
        private int id;
        
        public Person(int gId, string gFio):base(gId)
        {fio = gFio;}

        public string Fio{
            get {return fio;}
            set {fio = value;}}
    }

    public class Doctor : Person
    {
        private string spec;
        private int cab = 0;

        //public List<Pain> pains;

        public Doctor(int gId, string gFio, string gSpec, int gCab) : base(gId, gFio)
        {
            spec = gSpec;
            cab = gCab;
            //pains = new List<Pain>();
        }
       
        public string Specialization
        {
            get {return spec;}
            set {spec = value;}
        }
        public int Room
        {
            get {return cab;}
            set {cab = value;}
        }
        
    }

    public class Patient : Person
    {
        private char gender;
       private DateTime db;
        private DateTime dr;
        private int cardid;
        private int docid;
        private string address;
        private static int col = 0;
       
        public Patient(int gId, string gFio, string gAddress, char gGender, DateTime gDb,
            DateTime gDr, int gCardid, int gDocid) :base(gId,gFio)
        {
            address = gAddress;
            gender = gGender;
            db = gDb;
            dr = gDr;
            cardid = gCardid;
            docid = gDocid;
            //++col;
           // id = col;

        }

        

        public string Address
        {
            get {return address; }
            set {address = value;}
        }

        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public DateTime Db
        {
            get { return db; }
            set { db = value; }
        }

        public DateTime Dr
        {
            get { return dr; }
            set { dr = value; }
        }
        public int Cardid
        {
            get { return cardid; }
            set { cardid = value; }
        }
        public int Docid
        {
            get { return docid; }
            set { docid = value; }
        }

    }


}
