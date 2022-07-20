using System;

namespace Common
{
    //
    ///Базовый класс для юридических лиц
    //
    public class LegalEntityBase
    {
        
        public string LegalEntityName { get; set; }
        public string Ogrn { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string JurAddress { get; set; }
        public string FactAddress { get; set; }
    }
}
