using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Akhir.Models
{
    public interface IAutentikasi
    {
        string Login(string username, string password);
    }
}
