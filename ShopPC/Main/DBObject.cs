using Shop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Main.MockData
{
    public class DBObjects
    {
        public static void Initial(DBContent content)
        {
            if (!content.CategoryGPU.Any())
            {
                content.CategoryGPU.AddRange(CategoryGPU.Select(c => c.Value));
            }
            if (!content.CategorySSD.Any())
            {
                content.CategorySSD.AddRange(CategorySSD.Select(c => c.Value));
            }
            if (!content.CategoryRAM.Any())
            {
                content.CategoryRAM.AddRange(CategoryRAM.Select(c => c.Value));
            }
            if (!content.CategoryMB.Any())
            {
                content.CategoryMB.AddRange(CategoryMB.Select(c => c.Value));
            }
            if (!content.CategoryCPU.Any())
            {
                content.CategoryCPU.AddRange(CategoryCPU.Select(c => c.Value));
            }

            if (!content.CategoryPhone.Any())
            {
                content.CategoryPhone.AddRange(CategoryPhone.Select(c => c.Value));
            }
            if (!content.Phone.Any())
            {
                content.AddRange(
                   new Phone
                   {
                       Name = "Samsung S10",
                       Description = "Best phone by Samsung",
                       Img = "/img/samsung_galaxy_s10_6_128_gb.jpg",
                       Price = 23000,
                       Category = CategoryPhone["Flagman"]
                   },
                       new Phone
                       {
                           Name = "Nokia 3310",
                           Description = "Old phone",
                           Img = "/img/Nokia_3310.jpg",
                           Price = 700,
                           Category = CategoryPhone["Budget"]
                       },
                        new Phone
                        {
                            Name = "Vivo Y15 4/64GB",
                            Description = "Good phone",
                            Img = "/img/Vivo Y15.jpg",
                            Price = 6800,
                            Category = CategoryPhone["Budget"]
                        },
                            new Phone
                            {
                                Name = "Meizu X8 6/128GB",
                                Description = "Good phone",
                                Img = "/img/Meizu X8.png",
                                Price = 4799,
                                Category = CategoryPhone["Budget"]
                            },
                                new Phone
                                {
                                    Name = "Nokia 3.1 Plus",
                                    Description = "Good phone",
                                    Img = "/img/Nokia 3.1 Plus.jpg",
                                    Price = 2999,
                                    Category = CategoryPhone["Budget"]
                                }
                );
            }
            if (!content.CPU.Any())
            {
                content.AddRange(
                    new CPU
                    {
                        Name = "Intel Core i7 9700KF 3.6GHz",
                        Description = "Best CPU for games",
                        Img = "/img/Intel Core i7 9700KF 3.6GHz.jpg",
                        Price = 12900,
                        Category = CategoryCPU["Game"]
                    },
                       new CPU
                       {
                           Name = "Intel Pentium G4560",
                           Description = "Good CPU for offices",
                           Img = "/img/Intel Pentium G4560.jpg",
                           Price = 3700,
                           Category = CategoryCPU["Simple"]
                       },
                           new CPU
                           {
                               Name = "Intel Core i7 9700KF 3.6GHz",
                               Description = "Best CPU for games",
                               Img = "/img/Intel Core i7 9700KF 3.6GHz.jpg",
                               Price = 12900,
                               Category = CategoryCPU["Game"]
                           },
                       new CPU
                       {
                           Name = "Intel Pentium Gold G5400",
                           Description = "Good CPU for offices",
                           Img = "/img/Intel Pentium Gold G5400.jpg",
                           Price = 1600,
                           Category = CategoryCPU["Simple"]
                       },
                       new CPU
                       {
                           Name = "INTEL Core™ i7 9700K",
                           Description = "Good CPU for develop",
                           Img = "/img/INTEL Core™ i7 9700K.jpg",
                           Price = 11800,
                           Category = CategoryCPU["Develop"]
                       }
                );

            }
            if (!content.MB.Any())
            {
                content.AddRange(
                     new MB
                     {
                         Name = "MSI X299 GAMING PRO CARBON",
                         Description = "Best MB for games",
                         Img = "/img/MSI X299 GAMING PRO CARBON.jpg",
                         Price = 37499,
                         Category = CategoryMB["Game"]
                     },
                       new MB
                       {
                           Name = "ASRock FM2A68M-DG3+",
                           Description = "Good MB for offices",
                           Img = "/img/ASRock FM2A68M-DG3+.jpg",
                           Price = 1023,
                           Category = CategoryMB["Simple"]
                       },
                           new MB
                           {
                               Name = "MSI MEG X570 GODLIKE",
                               Description = "Best MB for games",
                               Img = "/img/MSI MEG X570 GODLIKE.jpg",
                               Price = 23426,
                               Category = CategoryMB["Game"]
                           },
                       new MB
                       {
                           Name = "Asus Prime A320M-K",
                           Description = "Good MB for offices",
                           Img = "/img/Asus Prime A320M-K.jpg",
                           Price = 1310,
                           Category = CategoryMB["Simple"]
                       },
                       new MB
                       {
                           Name = "ASRock X570 AQUA",
                           Description = "Good MB for develop",
                           Img = "/img/ASRock X570 AQUA.png",
                           Price = 123930,
                           Category = CategoryMB["Game"]
                       }
                );

            }
            if (!content.SSD.Any())
            {
                content.AddRange(
                    new SSD
                    {
                        Name = "Corsair CSSD-F1000GBMP600",
                        Description = "Best SSD for games",
                        Img = "/img/Corsair CSSD-F1000GBMP600.jpg",
                        Price = 7453,
                        Category = CategorySSD["Game"]
                    },
                       new SSD
                       {
                           Name = "Goodram SSD CL100",
                           Description = "Good SSD for offices",
                           Img = "/img/Goodram SSD CL100.jpg",
                           Price = 979,
                           Category = CategorySSD["Simple"]
                       },
                           new SSD
                           {
                               Name = "A-DATA XPG SX8200 Pro ASX8200PNP-1TT-C",
                               Description = "Best SSD for games",
                               Img = "/img/A-DATA XPG SX8200 Pro ASX8200PNP-1TT-C.jpg",
                               Price = 4011,
                               Category = CategorySSD["Game"]
                           },
                       new SSD
                       {
                           Name = "Team L3 EVO 240GB",
                           Description = "Good SSD for offices",
                           Img = "/img/Team L3 EVO 240GB.jpg",
                           Price = 949,
                           Category = CategorySSD["Simple"]
                       }
                );

            }
            if (!content.GPU.Any())
            {
                content.AddRange(
                    new GPU
                    {
                        Name = "Asus PCI-Ex GeForce RTX 2080 Ti",
                        Description = "Best GPU for games",
                        Img = "/img/Asus PCI-Ex GeForce RTX 2080 Ti.jpg",
                        Price = 36823,
                        Category = CategoryGPU["Game"]
                    },
                       new GPU
                       {
                           Name = "Asus PCI-Ex GeForce GT 710 1GB",
                           Description = "Good GPU for offices",
                           Img = "/img/Asus PCI-Ex GeForce GT 710 1GB.jpg",
                           Price = 1006,
                           Category = CategoryGPU["Simple"]
                       },
                           new GPU
                           {
                               Name = "Asus PCI-Ex GeForce RTX 2080 Super",
                               Description = "Best GPU for games",
                               Img = "/img/Asus PCI-Ex GeForce RTX 2080 Super.jpg",
                               Price = 22931,
                               Category = CategoryGPU["Game"]
                           },

                       new GPU
                       {
                           Name = "PNY PCI-Ex NVIDIA Quadro RTX6000 24GB",
                           Description = "Good GPU for develop",
                           Img = "/img/PNY PCI-Ex NVIDIA Quadro RTX6000 24GB.jpg",
                           Price = 123930,
                           Category = CategoryGPU["Develop"]
                       }
                );

            }
            if (!content.RAM.Any())
            {
                content.AddRange(
                    new RAM
                    {
                        Name = "DDR4 RAM 32GB Apacer 3000MHz",
                        Description = "Best RAM for games",
                        Img = "/img/DDR4 RAM 32GB Apacer 3000MHz.jpg",
                        Price = 4559,
                        Category = CategoryRAM["Game"]
                    },
                       new RAM
                       {
                           Name = "DDR4 RAM 4GB GOODRAM",
                           Description = "Good RAM for offices",
                           Img = "/img/DDR4 RAM 4GB GOODRAM.jpg",
                           Price = 619,
                           Category = CategoryRAM["Simple"]
                       },
                           new RAM
                           {
                               Name = "DDR4 RAM 16GB Apacer 2400MHz",
                               Description = "Best RAM for games",
                               Img = "/img/DDR4 RAM 16GB Apacer 2400MHz.jpg",
                               Price = 2800,
                               Category = CategoryRAM["Game"]
                           },
                       new RAM
                       {
                           Name = "DDR4 RAM 4GB Apacer 2666MHz",
                           Description = "Good RAM for offices",
                           Img = "/img/DDR4 RAM 4GB Apacer 2666MHz.jpg",
                           Price = 569,
                           Category = CategoryRAM["Simple"]
                       }
                
                );

            }
            content.SaveChanges();
        }


        private static Dictionary<string, CategoryPhone> categoryPhone;
        public static Dictionary<string, CategoryPhone> CategoryPhone
        {
            get
            {
                if (categoryPhone == null)
                {
                    var list = new CategoryPhone[]
                    {
                        new CategoryPhone { Name = "Flagman", Description = "Phone with hight price and extra functions" },
                        new CategoryPhone { Name = "Budget", Description = "Phone with low price without extra fubctions" }
                    };
                    categoryPhone = new Dictionary<string, CategoryPhone>();
                    foreach (CategoryPhone item in list)
                    {
                        categoryPhone.Add(item.Name, item);
                    }
                }
                return categoryPhone;
            }

        }
        private static Dictionary<string, CategoryCPU> categoryCPU;
        public static Dictionary<string, CategoryCPU> CategoryCPU
        {
            get
            {
                if (categoryCPU == null)
                {
                    var list = new CategoryCPU[]
                    {
                        new CategoryCPU{ Name="Game",Description="CPU for game"},
                    new CategoryCPU{ Name="Simple",Description="CPU with low price and without extra functions"},
                    new CategoryCPU{ Name="Develop",Description="CPU for develop"},
                    };
                    categoryCPU = new Dictionary<string, CategoryCPU>();
                    foreach (CategoryCPU item in list)
                    {
                        categoryCPU.Add(item.Name, item);
                    }
                }
                return categoryCPU;
            }

        }

        private static Dictionary<string, CategoryGPU> categoryGPU;
        public static Dictionary<string, CategoryGPU> CategoryGPU
        {
            get
            {
                if (categoryGPU == null)
                {
                    var list = new CategoryGPU[]
                    {
                        new CategoryGPU{ Name="Game",Description="GPU for game"},
                    new CategoryGPU{ Name="Simple",Description="GPU with low price and without extra functions"},
                    new CategoryGPU{ Name="Develop",Description="GPU for develop"},
                    };
                    categoryGPU = new Dictionary<string, CategoryGPU>();
                    foreach (CategoryGPU item in list)
                    {
                        categoryGPU.Add(item.Name, item);
                    }
                }
                return categoryGPU;
            }

        }

        private static Dictionary<string, CategoryMB> categoryMB;
        public static Dictionary<string, CategoryMB> CategoryMB
        {
            get
            {
                if (categoryMB == null)
                {
                    var list = new CategoryMB[]
                    {
                       new CategoryMB{ Name="Game",Description="MB for game"},
                    new CategoryMB{ Name="Simple",Description="MB with low price and without extra functions"}
                    };
                    categoryMB = new Dictionary<string, CategoryMB>();
                    foreach (CategoryMB item in list)
                    {
                        categoryMB.Add(item.Name, item);
                    }
                }
                return categoryMB;
            }

        }

        private static Dictionary<string, CategoryRAM> categoryRAM;
        public static Dictionary<string, CategoryRAM> CategoryRAM
        {
            get
            {
                if (categoryRAM == null)
                {
                    var list = new CategoryRAM[]
                    {
                        new CategoryRAM{ Name="Game",Description="RAM for game"},
                    new CategoryRAM{ Name="Simple",Description="RAM with low price and without extra functions"},
                    new CategoryRAM{ Name="Develop",Description="RAM for develop"}
                    };
                    categoryRAM = new Dictionary<string, CategoryRAM>();
                    foreach (CategoryRAM item in list)
                    {
                        categoryRAM.Add(item.Name, item);
                    }
                }
                return categoryRAM;
            }

        }

        private static Dictionary<string, CategorySSD> categorySSD;
        public static Dictionary<string, CategorySSD> CategorySSD
        {
            get
            {
                if (categorySSD == null)
                {
                    var list = new CategorySSD[]
                    {
                       new CategorySSD{ Name="Game",Description="SSD for game"},
                    new CategorySSD{ Name="Simple",Description="SSD with low price and without extra functions"}
                    };
                    categorySSD = new Dictionary<string, CategorySSD>();
                    foreach (CategorySSD item in list)
                    {
                        categorySSD.Add(item.Name, item);
                    }
                }
                return categorySSD;
            }

        }

    }
}

