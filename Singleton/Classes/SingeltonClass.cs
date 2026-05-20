using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Classes
{
    //lazy
    public class SingeltonClass
    {
        private static SingeltonClass instance;
        private SingeltonClass() { }
        public static SingeltonClass GetInstance()
        {
            if(instance == null)
            {
                instance = new SingeltonClass();
            }
    
            return instance;
            
        }
    }
    /*
    //eager (thread safe)
    public class SingeltonClass
    {
        private static readonly SingeltonClass instance = new SingeltonClass();
        private SingeltonClass() { }
        public static SingeltonClass GetInstance()
        {
            return instance;
        }
    }
    */
}
