using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Sodv2101_Assignment3TradingCards_KailanBates
{
    public class Player : INotifyPropertyChanged
	{
        private static int _currentId = 1;

		private string _name;
		private string _team;
		private int _teamColorR;
		private int _teamColorG;
		private int _teamColorB;
		private int _interceptions;
		private int _passesDefended;
		private int _totalTackles;
		private int _soloTackles;
		private string _image;




		public int Id { get; set; }
		public string Name 
		{ 
			get { return _name; }
			set
			{
				if (_name != value)
					_name = value;
				OnPropertyChanged("Name");
			}
		}
		public string Team
		{
			get { return _team; }
			set
			{
				if (_team != value)
					_team = value;
				OnPropertyChanged("Team");
			}
		}
		public int TeamColorR
		{
			get { return _teamColorR; }
			set
			{
				if (_teamColorR != value)
					_teamColorR = value;
				OnPropertyChanged("TeamColorR");
			}
		}
		public int TeamColorG
		{
			get { return _teamColorG; }
			set
			{
				if (_teamColorG != value)
					_teamColorG = value;
				OnPropertyChanged("TeamColorG");
			}
		}
		public int TeamColorB
		{
			get { return _teamColorB; }
			set
			{
				if (_teamColorB != value)
					_teamColorB = value;
				OnPropertyChanged("TeamColorB");
			}
		}
		public int Interceptions
		{
			get { return _interceptions; }
			set
			{
				if (_interceptions != value)
					_interceptions = value;
				OnPropertyChanged("Interceptions");
			}
		}
		public int PassesDefended
		{
			get { return _passesDefended; }
			set
			{
				if (_passesDefended != value)
					_passesDefended = value;
				OnPropertyChanged("PassesDefended");
			}
		}
		public int TotalTackles
		{
			get { return _totalTackles; }
			set
			{
				if (_totalTackles != value)
					_totalTackles = value;
				OnPropertyChanged("TotalTackles");
			}
		}
		public int SoloTackles
		{
			get { return _soloTackles; }
			set
			{
				if (_soloTackles != value)
					_soloTackles = value;
				OnPropertyChanged("SoloTackles");
			}
		}
		public string Image
		{
			get { return _image; }
			set
			{
				if (_image != value)
					_image = value;
				OnPropertyChanged("Image");
			}
		}



		public Player() 
		{
			Id = _currentId;
			_currentId++;
		}
        public Player(string name, string team, int r, int g, int b, int inter, int pass, int tackle, int sTackle, string image)
        {
            Id = _currentId;
            Name = name;
            Team = team; 
            TeamColorR = r;
            TeamColorG = g;
            TeamColorB = b;
            Interceptions = inter;
            PassesDefended = pass;
            TotalTackles = tackle;
            SoloTackles = sTackle;
            Image = image;

            _currentId++;
        }

		public override bool Equals(object? obj)
        {
            if (obj is Player other)
            {
                return Id == other.Id &&
                       Name == other.Name &&
                       Team == other.Team &&
                       TeamColorR == other.TeamColorR &&
				       TeamColorG == other.TeamColorG &&
				       TeamColorB == other.TeamColorB;

			}
            return false;
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Team, TeamColorR, TeamColorG, TeamColorB);
        }

		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
