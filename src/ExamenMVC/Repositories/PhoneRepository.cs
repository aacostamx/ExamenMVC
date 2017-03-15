using System;
using ExamenMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ExamenMVC.Repositories
{
    public class PhoneRepository : IPhoneRepository
    {
        private _Context context;
        public DbSet<Phone> phoneEntity;

        public PhoneRepository(_Context context)
        {
            this.context = context;
            phoneEntity = context.Set<Phone>();
        }

        public void addPhones(List<Phone> phones)
        {
            context.AddRange(phones);
            context.SaveChanges();
        }

        public void deletePhone(string employeeNumber)
        {
            var delete = phoneEntity.Where(c => c.EmployeeNumber == employeeNumber).FirstOrDefault();

            if (delete != null)
            {
                phoneEntity.Remove(delete);
                context.SaveChanges();
            }
        }
    }
}
