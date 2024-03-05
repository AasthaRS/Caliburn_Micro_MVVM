using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_UI_MVVM.Models;

namespace WPF_UI_MVVM.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
		private string _firstName = "Aastha";
		private string _lastName = "Gupta";
        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel> ();
        private PersonModel _selectedPerson;

        public ShellViewModel()
        {
            People.Add(new PersonModel { FirstName = "Aastha", LastName = "Gupta" });
            People.Add(new PersonModel { FirstName = "Shiv", LastName = "Rajput" });
            People.Add(new PersonModel { FirstName = "Karan", LastName = "Singh" });
            People.Add(new PersonModel { FirstName = "Reena", LastName = "Gill" });
        }

        public string FirstName
		{
			get 
			{ 
				return _firstName; 
			}
			set 
			{ 
				_firstName = value;
				NotifyOfPropertyChange(() => FirstName);
				NotifyOfPropertyChange(() => FullName);
			}
		}

		public string LastName
		{
			get { return _lastName; }
			set { 
				_lastName = value; 
				NotifyOfPropertyChange(() =>  LastName);
                NotifyOfPropertyChange(() => FullName);
            }
		}

		public string FullName
		{
			get 
			{ 
				return $"{FirstName} {LastName}"; 
			}
		}

		public BindableCollection<PersonModel> People
		{
			get { return _people; }
			set { _people = value; }
		}

		public PersonModel SelectedPerson
        {
			get { return _selectedPerson; }
			set { 
				_selectedPerson = value; 
				NotifyOfPropertyChange(() => SelectedPerson);
			}
		}

		public bool CanClearText(string firstName, string lastName)
		{
			return !String.IsNullOrWhiteSpace(firstName) || !String.IsNullOrWhiteSpace(lastName);
		}

		public void ClearText(string firstName, string lastName)
		{
			FirstName = "";
			LastName = "";
		}

		public void LoadPageOne()
		{
			ActivateItemAsync(new FirstChildViewModel());
		}

		public void LoadPageTwo()
		{
			ActivateItemAsync(new SecondChildViewModel());
		}

	}
}
