using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skillbox_HomeWork_20.Models
{
    public static class SampleData
    {
        public static void Initialize(PhoneBook context)
        {
            if (!context.People.Any())
            {
                context.People.AddRange(
                    new Person
                    {
                        LastName = "Брентон",
                        FirstName = "Джеф",
                        MiddleName = "младший",
                        Phone = "212-888-77625",
                        Address = "601 W 26TH NEW YORK NY 10001-1131 USA",
                        Info = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sint quos earum quae delectus enim omnis ut suscipit perspiciatis cum quas facere cumque numquam perferendis, repellat voluptate corporis ipsam nisi placeat."
                    },

                     new Person
                     {
                         LastName = "Харрис",
                         FirstName = "Билл",
                         MiddleName = "Гэбриел",
                         Phone = "212-639-9675",
                         Address = "150 W 28TH NEW YORK NY 10001-6181 USA",
                         Info = "Lorem Minima harum quasi libero corporis maiores hic soluta atque mollitia! Iste eaque omnis dicta corporis illum quos voluptatibus placeat! Vitae, sequi et!"
                     },

                      new Person
                      {
                          LastName = "Смит",
                          FirstName = "Лиам",
                          MiddleName = "Гарольд",
                          Phone = "212-5439-8722",
                          Address = "7  PENN NEW YORK NY 10001-3975 USA",
                          Info = "Voluptate, debitis itaque a laborum magnam architecto repudiandae vitae assumenda nulla inventore totam odio error pariatur dicta modi ex quod quaerat ducimus iusto tempora fugit explicabo. Recusandae reprehenderit mollitia itaque."
                      },

                       new Person
                       {
                           LastName = "Ричардсон",
                           FirstName = "Мэйсон",
                           MiddleName = "Джейкоб ",
                           Phone = "212-639-8787",
                           Address = "450 W 31ST NEW YORK NY 10001-4607 USA",
                           Info = "Distinctio aspernatur quam enim ipsam rem dignissimos fuga aut exercitationem iusto corrupti minus, temporibus a eveniet ab necessitatibus, suscipit qui excepturi quaerat officia molestias odit, eligendi nihil quis? Cum, enim!"
                       },

                        new Person
                        {
                            LastName = "Льюис",
                            FirstName = "Джейн",
                            MiddleName = "Джесси",
                            Phone = "212-112-8722",
                            Address = "7800  CLAY POINT FISHERS ISLAND NY 06390-7846 USA",
                            Info = "Vero eos expedita incidunt cum eum quam magni, minus quasi autem inventore, rerum accusantium, pariatur enim animi! Ab nostrum, magni corporis sed praesentium quaerat aliquam vitae, quam sequi sapiente omnis?"
                        },

                         new Person
                         {
                             LastName = "Митчелл",
                             FirstName = "Итан",
                             MiddleName = "Лоренс",
                             Phone = "212-434-5665",
                             Address = "115 W 29TH NEW YORK NY 10001-5074 USA",
                             Info = "Molestiae incidunt animi, dolores vitae nulla delectus illo porro expedita possimus aliquid quisquam earum repellendus consectetur magni consequatur, adipisci unde! Pariatur error facere dolor adipisci quasi molestias, necessitatibus nostrum optio."
                         },

                          new Person
                          {
                              LastName = "Вашингтон",
                              FirstName = "Уильям",
                              MiddleName = "Лестер",
                              Phone = "212-665-88765",
                              Address = "365 W 25TH NEW YORK NY 10001-5816 USA",
                              Info = "Eum cum delectus laborum aliquid repellendus minima et tempora blanditiis a eligendi, ducimus natus, excepturi voluptatibus laudantium quasi quo maxime? Eveniet voluptas hic voluptate necessitatibus provident labore ratione repudiandae excepturi."
                          },

                           new Person
                           {
                               LastName = "Тёрнер",
                               FirstName = "Памела",
                               MiddleName = "Мэтью",
                               Phone = "212-326-9365",
                               Address = "1239  BROADWAY NEW YORK NY 10001-4398 USA",
                               Info = "Nobis laboriosam nisi reiciendis iste illum! Hic saepe cumque architecto at labore! Totam, suscipit amet soluta nihil facilis voluptas minima sequi. Commodi quis ad fugiat ducimus accusamus vero praesentium voluptatibus."
                           },

                            new Person
                            {
                                LastName = "Диас",
                                FirstName = "Майкл",
                                MiddleName = "Нэйтен",
                                Phone = "212-932-94325",
                                Address = "115 W 29TH NEW YORK NY 10001-5020 USA",
                                Info = "Ex dolorum optio earum libero quisquam officiis placeat dolore, natus soluta excepturi vero veniam atque rerum minima corrupti illo suscipit commodi! Quam, nesciunt. Earum commodi sunt, eaque ut et totam!"
                            },

                             new Person
                             {
                                 LastName = "Робинсон",
                                 FirstName = "Джеймс",
                                 MiddleName = "Даниэль",
                                 Phone = "212-663-4565",
                                 Address = "136 W 28TH NEW YORK NY 10001-6168 USA",
                                 Info = "Quisquam sequi non consequatur ab delectus debitis nemo adipisci dolor excepturi ratione dolorum explicabo, odio odit temporibus natus tempora dicta cupiditate, quaerat sint facere quidem. Illo quibusdam magni quod tenetur."
                             }
                    );
                context.SaveChanges();
            }
        }
    }
}
