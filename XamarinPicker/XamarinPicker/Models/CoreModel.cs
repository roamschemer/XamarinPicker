using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace XamarinPicker.Models {
    public class Person : BindableBase {

        public string Name {
            get => name;
            set => SetProperty(ref name, value);
        }
        private string name;

    }

    public class Category : BindableBase {

        public string Name {
            get => name;
            set => SetProperty(ref name, value);
        }
        private string name;

        public ObservableCollection<Person> Persons { get; set; }

        public void AddPerson() {
            Persons.Add(new Person() { Name = "人物" });
        }

        public void DeletePerson(Person person) {
            if (Persons.Count == 1) return;
            Persons.Remove(person);
        }

        public void Clear() => Persons.Clear();
    }

    public class CoreModel : BindableBase {

        public ObservableCollection<Category> Categorys { get; set; } = new ObservableCollection<Category>();

        public void AddCategory() {
            Categorys.Add(new Category() {
                Name = "カテゴリ",
                Persons = new ObservableCollection<Person>() {
                    new Person() { Name = "人物" }
                }
            });
        }

        public void DeleteCagegory(Category category) {
            if (Categorys.Count == 1) return;
            Categorys.Remove(category);
        }

        public void CreateSample() {
            Categorys.Clear();
            foreach (var x in Aveter2ten0()) { Categorys.Add(x); }
        }

        public void Clear() => Categorys.Clear();

        private static ObservableCollection<Category> Aveter2ten0() =>
            new ObservableCollection<Category>(){
                new Category() {
                    Name = "ひそうら", Persons = new ObservableCollection<Person>() {
                        new Person(){Name = "白石ひなた"},
                        new Person(){Name = "都三代らみょん"},
                        new Person(){Name = "三田そにあ"},
                        new Person(){Name = "縁うか"}
                    }
                },
                new Category() {
                    Name = "九条家", Persons = new ObservableCollection<Person>() {
                        new Person(){Name = "九条林檎"},
                        new Person(){Name = "九条棗"},
                        new Person(){Name = "九条杏子"},
                        new Person(){Name = "九条茘枝"},
                    }
                },
                new Category() {
                    Name = "ほうれん草ず", Persons = new ObservableCollection<Person>() {
                        new Person() { Name = "白乃クロミ"},
                        new Person() { Name = "碧惺スキア"},
                        new Person() { Name = "紫吹ふうか"},
                        new Person() { Name = "菜花なな"},
                    }
                },
                new Category() {
                    Name = "フカヒレシスターズ", Persons = new ObservableCollection<Person>() {
                        new Person() { Name = "巻乃もなか"},
                        new Person() { Name = "幸糖ミュウミュウ"},
                        new Person() { Name = "青咲ローズ"},
                        new Person() { Name = "泡沫調"},
                    }
                },
                new Category() {
                    Name = "ユイしあ", Persons = new ObservableCollection<Person>() {
                        new Person() { Name = "結目ユイ"},
                        new Person() { Name = "水瀬しあ"},
                    }
                },
            };
    }
}
