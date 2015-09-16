namespace FSMFMVC.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<FSMFMVC.Models.StaticDataDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FSMFMVC.Models.StaticDataDBContext context)
        {
            getBiograhies(context);
            getExecutive(context);
            getDonors(context);
        }

        private static void getBiograhies(StaticDataDBContext context)
        {
            context.Biographies.AddOrUpdate(i => i.Title,
                new Biography
                {
                    ID = 1,
                    Title = "Dr. Leanne Regehr – Senior Piano, Vocal/Choral/Speech Arts/Musical Theatre",
                    Description = "Leanne Regehr is a versatile and sensitive pianist who has captivated increasingly diverse audiences across North America. She is the featured soloist in a live recording of Victor Davies' Mennonite Piano Concerto with the Winnipeg Symphony Orchestra, and is currently based in Edmonton where she serves on the faculties of the University of Alberta and The King’s University. Leanne’s reputation in opera has grown through engagements as a répétiteur with Shreveport Opera, Mercury Opera, and Edmonton Opera. Her dedication to the development of young singers has been shown through her work as a faculty member with Opera NUOVA, a staff pianist for Sherrill Milnes' VoicExperience Program in Florida, and as a Coaching Fellow at the Aspen Music Festival. She is widely recognized for her intuitive ability to collaborate with other musicians across an extensive range of repertoire. Leanne completed her Doctor of Music in Piano Performance at Northwestern University and explored further studies at the Banff School of Fine Arts, the Universitat Mozarteum in Salzburg and the Aspen Music Festival. She is the accompanist for the Richard Eaton Singers and freelances as a soloist, vocal coach, recital partner, and adjudicator.",
                    ImagePath = "LeanneRegehr.jpg"
                },
                new Biography
                {
                    ID = 2,
                    Title = "Sheryl Bowhay – Instrumental",
                    Description = "Sheryl Bowhay specializes in instrumental music education, and has taught bands, orchestras, and choirs at the elementary, middle school, and high school levels in Alberta and Ontario, Canada. Ms. Bowhay has actively participated on committees and boards at the local, provincial and national level. Sheryl served various roles on the Alberta Band Association, including President in 1995-1996, she was the founding President of the Ontario Band Association, and is currently Past President of the International Bandmasters Fraternity, Phi Beta Mu. Ms. Bowhay has been acknowledged for her leadership in teaching and the fine arts and was recently honored by the Ontario Band Association with an Honorary Lifetime Membership. Sheryl has performed in community orchestras and bands throughout her career, and in 2012-2013 had the opportunity to perform with the Harmonie Municipale Aix en Provence in Southern France. Ms. Bowhay is active as an adjudicator, guest conductor and clinician.",
                    ImagePath = "SherylBowhay.jpg"
                },
                new Biography
                {
                    ID = 3,
                    Title = "Josphine van Lier – Strings",
                    Description = "A versatile musician, Josephine van Lier is equally at ease on a baroque cello or a 5 string violoncello piccolo as on their contemporary counterparts, using instruments and bows whose designs, construction and material span over 400 years in origin; from the gut strings of her baroque cello to her 1870 cello and the space-age material of her carbon-fibre cello. She therefore covers a wide variety of repertoire utilizing the endless possibilities that this range of instruments, string set-ups and bows allow her.",
                    ImagePath = "JosphinevanLier.jpg"
                },
                new Biography
                {
                    ID = 4,
                    Title = "Carmen Kulak – Junior Piano",
                    Description = "Carmen Kulak earned a Bachelor of Music Degree from the University of Alberta where she was a student of Stephane Lemelin and Janet Scott-Hoyt. She currently has a successful private piano studio in Stony Plain, AB where she teaches students of all ages and levels. She is frequently called on to adjudicate, accompany voice and violin students in and around the Edmonton area and is an active member and volunteer with the music ministry at St. Matthew Lutheran Church in Stony Plain. Carmen has a deep commitment to furthering music education in her community, and hopes to inspire a love of music for each of her students. She has over 20 years experience as an accompanist, performer, and teacher. Carmen is an active member of the Parkland Music Teachers Association, a member of the Alberta Registered Music Teachers Association and the Alberta Piano Teachers Association.",
                    ImagePath = "CarmenKulak.jpg"
                },
                new Biography
                {
                    ID = 5,
                    Title = "Susan Galloway – Handbells",
                    Description = "Susan Galloway has been ringing bells since she first saw a children’s choir play in Olds Alberta. She was hooked and continues to love to play and teach handbells to anyone who wants to learn. Presently she plays in the auditioned advanced community handbell group called JUBILOSO! Bells of Concordia. Susan always enjoying coming to the Fort Saskatchewan music festival as she grew up here and attended Fort Elementary.",
                    ImagePath = "SusanGalloway.jpg"
                }
            );
        }

        private static void getExecutive(StaticDataDBContext context)
        {
            context.Executive.AddOrUpdate(i => i.Title,
                new Executive
                {
                    ID = 1,
                    Title = "Melanie Smith-Doderai - Treasurer",
                    Description = "Melanie Smith-Doderai holds a B.A, B.Ed, M.Ed and is an active member of the Alberta Registered Music Teachers Association, Alberta Strings Association and the Alberta Society of Fiddlers. Melanie has been awarded the 2009 Excellence in Music Teaching Award as well as the 2012 - 2014 CMFTA Recognition For Professional Achievement Award. In addition to this, she volunteers as the acting treasurer for the Fort Saskatchewan Music Festival and has written and published nine theory books for string instruments through Mel Bay Publications. Melanie believes that a well-rounded music program in the hands of a skilled and dedicated teacher will foster an enduring love of music in all students. Her goal is to inspire students to love music and to promote musicality and a commitment to lifelong learning in all of her students. Melanie currently adjudicates and teaches fiddle camps around Alberta and teaches privately out of her residence in Fort Saskatchewan, Alberta. You can contact Melanie at vioteacher@hotmail.com",
                    Email = "vioteacher@hotmail.com",
                    ImagePath = "MelanieSmithDoderai.jpg"
                },
                new Executive
                {
                    ID = 2,
                    Title = "Joan Orchard - Secretary",
                    Description = "I have been involved with the Fort Music Festival for over 15 years. I am currently the secretary and assist with the vocal section of the festival. In my spare time, I ring handbells with two choirs and conduct bells at a local school.",
                    ImagePath = "JoanOrchard.jpg"
                },
                new Executive
                {
                    ID = 3,
                    Title = "Helen Akerboom - Past President, Syllabus Chair, and Piano Coordinator",
                    Description = "A long-time member of the executive committee of the Fort Saskatchewan Music Festival Association, Helen is excited to be back for another year of activities. As syllabus chair, she advises on festival administration to parents, adjudicators, and festival executive committee members; as piano coordinator, she organizes and hosts the piano sessions for participants. She feels honoured to be working with such a dedicated team of volunteers and such an enthusiastic group of young musicians. Helen would like to thank her supportive family and looks forward to the culmination of months of planning and collaboration when everyone comes together for another celebration of music. Enjoy the festival!",
                    ImagePath = "HelenAkerboom.jpg"
                },
                new Executive
                {
                    ID = 4,
                    Title = "Jennifer Pollack - Past President",
                    Description = "Jennifer is happy to be involved in the Fort Saskatchewan Music Festival Association and has sat as President from 2006 - 2014. Former piano teacher and now a Realtor at RE/MAX Real Estate.",
                    ImagePath = "jenniferPollack.jpg"
                },
                new Executive
                {
                    ID = 5,
                    Title = "Mike Akerboom - Awards Coordinator",
                    Description = "Involved with the Fort Saskatchewan Music Festival Association for a number of years, Mike is pleased to continue his work behind the scenes as an awards coordinator. He liaises with the fundraising members of the executive committee to ensure trophies and plaques are available for distribution at the Gala Concert - to the delight of the award recipients, donors, and parents! He is also happy to make himself available to the executive committee for any odd jobs. Mike maintains that by working together, we make Fort Saskatchewan a great place to live.",
                    ImagePath = "MikeAkerboom.jpg"
                },
                new Executive
                {
                    ID = 5,
                    Title = "Sharon Cameron - Adjudicator Chair",
                    Description = "I have worked with the Fort Saskatchewan Music Festival since I became a resident of Fort Saskatchewan in 1977. In my 36 years volunteering for the Festival, I have held most executive positions from President to adjudicator chair, which is my current position. Having taught elementary school music with the Edmonton Public School Board, as well as piano lessons for the last 35 years, continuing to work with young students has been a very natural continuation of my love for music.",
                    ImagePath = "SharonCameron.jpg"
                },
                new Executive
                {
                    ID = 5,
                    Title = "Erin Gott - Board Member",
                    Description = "Erin began taking voice lessons at the age of 8, and by the age of 14 she was accepted into Edmonton Musical Theatre under the Direction of the late Dr. Dasha Goody. While performing with Edmonton Musical Theatre Erin was able to work along side many talented artists in the performances of \"Something Old, Something New\" and \"Encore! The best of 20 Years.\" She was also a vocalist in the production \"Antigravity, a Musical Dance Experience\" and enjoyed being a cast member of \"Notre Dame of Paris\" After Erin Graduated High School she followed her dreams which led her to Toronto, Ontario where she attended the Randolph Academy for the Performing Arts. There she studied Voice, Voice Performance, Choral, Musicology, Musical Theatre Presentation/History, Improvisation, Movement for Actors, Scene Study, Voice & Text, Ballet, Jazz and Dance History. In 2001, after College Erin moved back home to Alberta and started a family. She opened the doors to Gott the Gift Vocal Studio in 2004. In 2011 Erin branched out and opened Gott the Gift Music Studio to welcome other teachers. Erin loves what she does and is thrilled to share her knowledge with others! To contact Erin, email her at gottthegift@gmail.com.",
                    Email = "gottthegift@gmail.com.",
                    ImagePath = "ErinGott.jpg"
                },
                new Executive
                {
                    ID = 5,
                    Title = "Sharon Hart",
                    Description = "Executive",
                    ImagePath = "SharonHart.jpg"
                },
                new Executive
                {
                    ID = 5,
                    Title = "David Spearing",
                    Description = "Executive",
                    ImagePath = "DavidSpearing.jpg"
                },
                new Executive
                {
                    ID = 5,
                    Title = "Kim Heatherington",
                    Description = "Executive",
                    ImagePath = "KimHeatherington.jpg"
                }
            );
        }

        private void getDonors(StaticDataDBContext context)
        {
            context.Donor.AddOrUpdate(i => i.Title,
                new Donor
                {
                    ID = 1,
                    Title = "Platinum Level Donors",
                    Description = "$1000.00 plus",
                    ImagePath = "Platinum.png"
                },
                 new Donor
                 {
                     ID = 2,
                     Title = "Gold Level Donors",
                     Description = "$500.00 - $999.99",
                     ImagePath = "Gold.png"
                 },
                  new Donor
                  {
                      ID = 3,
                      Title = "Silver Level Donors",
                      Description = "$250.00- $499.99",
                      ImagePath = "Silver.png"
                  },
                   new Donor
                   {
                       ID = 4,
                       Title = "Bronze Level Donors",
                       Description = "up to $249.99",
                       ImagePath = "Bronze.png"
                   }
            );
        }
    }
}
