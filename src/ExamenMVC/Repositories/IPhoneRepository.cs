using ExamenMVC.Models;
using System;
using System.Collections.Generic;

namespace ExamenMVC.Repositories
{
    public interface IPhoneRepository
    {
        void addPhones(List<Phone> phones);
        void deletePhone(string employeeNumber);
    }
}
