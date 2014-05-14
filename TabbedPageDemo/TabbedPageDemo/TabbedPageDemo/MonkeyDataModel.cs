﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TabbedPageDemo
{
    public class MonkeyDataModel 
    {
        static MonkeyDataModel()
        {
            All = new ObservableCollection<MonkeyDataModel>
            {
                new MonkeyDataModel
                {
                    Name = "Chimpanzee",
                    Family = "Hominidae",
                    Subfamily = "Homininae",
                    Tribe = "Panini",
                    Genus = "Pan",
                    PhotoUrl="http://upload.wikimedia.org/wikipedia/commons/thumb/6/62/Schimpanse_Zoo_Leipzig.jpg/640px-Schimpanse_Zoo_Leipzig.jpg"
                },
                new MonkeyDataModel
                {
                    Name = "Orangutan",
                    Family = "Hominidae",
                    Subfamily = "Ponginae",
                    Genus = "Pongo",
                    PhotoUrl="http://upload.wikimedia.org/wikipedia/commons/thumb/1/14/Orangutan_-Zoologischer_Garten_Berlin-8a.jpg/202px-Orangutan_-Zoologischer_Garten_Berlin-8a.jpg"
                },
                new MonkeyDataModel
                {
                    Name = "Tamarin",
                    Family = "Callitrichidae",
                    Genus = "Saguinus",
                    PhotoUrl="http://upload.wikimedia.org/wikipedia/commons/thumb/8/85/Tamarin_portrait_2_edit3.jpg/640px-Tamarin_portrait_2_edit3.jpg"
                }
            };
        }

        public string Name { set; get; }

        public string Family { set; get; }

        public string Subfamily { set; get; }

        public string Tribe { set; get; }

        public string Genus { set; get; }

        public string PhotoUrl { set; get; }

        public static IList<MonkeyDataModel> All { set; get; }
    }
}
