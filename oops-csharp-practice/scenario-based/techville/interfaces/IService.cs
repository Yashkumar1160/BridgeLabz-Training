using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techville.interfaces
{
    public interface IService
    {
        void Register();             
        void Cancel();                
        void CheckStatus();          
        void BookService(string citizenName);         
        void BookService(string citizenName, int priority);
        void DisplayServiceDetails(); 
    }
}