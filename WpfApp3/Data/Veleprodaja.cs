using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektniZadatak.NewFolder1
{
    public enum Role { Zaposleni, Menadzer, Administrator };
    public abstract class Korisnici
    {
        public string Username { get; set; }

        protected string _password = Guid.NewGuid().ToString(); // Generate a random password by default
        public string Password
        {
            set
            {
                if (!SetPassword(value))
                {
                    throw new ArgumentException("Password not complex enough", "Password");
                }
            }
        }

        public bool VerifyPassword(string pass)
        {
            return (String.Compare(pass, _password) == 0);
        }

        // Abstract method for setting the password
        // Teachers and Students have different password complexity policies
        public abstract bool SetPassword(string pwd);
    }
    //Creating Roles and User clasess 
    public class Zaposleni : Korisnici, IComparable<Zaposleni>
    {
        public int ZaposleniID { get; set; }
        public int MenadzerID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        // Constructor to initialize the properties of a new Zaposleni
        public Zaposleni(int zaposleniID, string userName, string password, string firstName, string lastName, int menadzerID)
        {
            ZaposleniID = zaposleniID;
            Username = userName;
            Password = password;
            Ime = firstName;
            Prezime = lastName;
            MenadzerID = menadzerID;
        }

        // Default constructor 
        public Zaposleni()
        {
            ZaposleniID = 0;
            Username = String.Empty;
            Password = String.Empty;
            Ime = String.Empty;
            Prezime = String.Empty;
            MenadzerID = 0;
        }

        // Compare Zaposleni objects based on their LastName and FirstName properties
        public int CompareTo(Zaposleni other)
        {
            // Concatenate the LastName and FirstName of this zaposleni
            string thisZaposleniFullName = Prezime + Ime;

            // Concatenate the LastName and FirstName of the "other" zaposleni
            string otherZaposleniFullName = other.Prezime + other.Ime;

            // Use String.Compare to compare the concatenated names and return the result
            return (String.Compare(thisZaposleniFullName, otherZaposleniFullName));
        }
       
                public override bool SetPassword(string pwd)
                {
                    // If the password provided as the parameter is at least 6 characters long then save it and return true
                    if (pwd.Length >= 6)
                    {
                        _password = pwd;
                        return true;
                    }
                    // If the password is not long enough, then do not save it and return false
                    return false;
                }
            }
        }
    
            
