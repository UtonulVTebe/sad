using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace InspectorLib
{
    public static class FunctionInsp
    {
        static string _name = "Автоинспекция г. Чита",
            _inspector = "Васильев В.И.";
        static string[] _members = { "Иванов И.И.", "Заринов Т.А.", "Миронов А.В.", "Васильев В.И."};

        public static string GetInspector() => _inspector;
        public static string GetCarInspection() => _name;
        public static string[] GetWorker() => _members;
        public static void AddWorker(string nWorker)
        {
            Array.Resize(ref _members, _members.Length + 1);
            _members[_members.Length - 1] = nWorker;
        }
        public static string GenerateNumber(int number, char symbol, int code)
        {
            string fmt = $"{symbol.ToString().ToUpper()}0000_{code}";
            char[] trueSymv = { 'А', 'В', 'Е', 'К', 'М', 'Н', 'О', 'Р', 'С', 'Т', 'У', 'X'};

            if (trueSymv.Contains(Convert.ToChar(symbol.ToString().ToUpper())) && number < 10000 && number > 0 && code > 0 && code < 1000)
                return number.ToString(fmt);
            else return "Не корректно введено значение";
                
        }
        public static bool SetInspector(string fullname)
        {
            if (_members.Contains(fullname)) 
                _inspector = fullname;
            else
                return false;
            return true;
        }
    }
}
