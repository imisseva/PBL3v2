﻿    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace PBL3.DTO
    {
        public class StaffDTO
        {
            public int ID_account { get; set; }
            public string Name { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            public string CCCD { get; set; }
            public string home_address { get; set; }
            public DateTime Dob { get; set; }
            public string NoiSinh { get; set; }
            public string Gender { get; set; }
            public string ID_station { get; set; }
            public byte[] AvatarImage { get; set; }
        
    }
}
