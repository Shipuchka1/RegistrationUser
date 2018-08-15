using Company.Register.Lib.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationUser.Models
{
    [Appoint]
    public class MyUser
    {
        public virtual ICollection<MyAddress> Address { get; set; }
        [Required]
        public string User1CGuid { get; set; }

        public string Patronymic { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string NameOrganization { get; set; }
        [Required]
        public DateTime? UpdateDate { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public int Status { get; set; }
    
        public virtual ICollection<BankDetail> BankDetail { get; set; }

        public DateTime? CertDateIssue { get; set; }

        public string CertSeries { get; set; }
        [Required]
        public string Kbe { get; set; }
        [Required]
        public string Bin { get; set; }
        [Required]
        public int IsLegalEntity { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailElInvoice { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [Compare("RePassword")]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string RePassword { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public int UserId { get; set; }

        public string CertNumber { get; set; }

        public virtual ICollection<Phone> Phone { get; set; }

        public Company.Register.Lib.Model.Phone[] ContactNumbers { get; set; } = new Company.Register.Lib.Model.Phone[1];

        public Company.Register.Lib.Model.Address AddressPhysical { get; set; }

        public Company.Register.Lib.Model.Address AddressLegal { get; set; }

        public BankDetail[] BankDetails { get; set; } = new BankDetail[1];
        public bool RememberMe { get; set; }

        public static explicit operator UserAccount(MyUser user)
        {
            UserAccount userAccount = new UserAccount()
            {
                UserId = user.UserId,
                Login = user.Login,
                Password = user.Password,
                Email = user.Email,
                EmailElInvoice = user.EmailElInvoice,
                IsLegalEntity = user.IsLegalEntity,
                Bin = user.Bin,
                Kbe = user.Kbe,
                CertSeries = user.CertSeries,
                CertNumber = user.CertNumber,
                CertDateIssue = user.CertDateIssue,
                Status = user.Status,
                CreateDate = user.CreateDate,
                UpdateDate = user.UpdateDate,
                NameOrganization = user.NameOrganization,
                Surname = user.Surname,
                Name = user.Name,
                Patronymic = user.Patronymic,
                User1CGuid = user.User1CGuid,
                ContactNumbers = user.ContactNumbers,
                AddressPhysical = user.AddressPhysical,
                BankDetails = user.BankDetails,
                AddressLegal = user.AddressLegal
            };
            return userAccount;
        }

        
        }

    public class AppointAttribute : ValidationAttribute
    {
        public string Error { get; set; }
        public AppointAttribute()
        {
            Error = "";
            ErrorMessage = "-";
        }
        public override bool IsValid(object value)
        {
            MyUser user = value as MyUser;
            Model1 db = new Model1();
            if (user == null || string.IsNullOrEmpty(user.Login) || user.Bin.Length != 12 || user.Kbe.Length != 2)
            {
                ErrorMessage += " Введите корректные данные";
                return false;
            }

            if (user.IsLegalEntity == 1)
            {
                if (string.IsNullOrEmpty(user.NameOrganization))
                {
                    ErrorMessage += " Введите название организации";
                    return false;
                }

                if (!string.IsNullOrEmpty(user.Patronymic) || !string.IsNullOrEmpty(user.Name) || !string.IsNullOrEmpty(user.Surname))
                {
                    ErrorMessage += " Поля Name, Surname, Patronymic должны быть пустыми";
                    return false;
                }

               
            }

            if (db.Users.Select(s => s.Login).Contains(user.Login))
            {
                ErrorMessage += " Данный логин уже существует";
                return false;
            }
            else
                return true;
        }
    }
}