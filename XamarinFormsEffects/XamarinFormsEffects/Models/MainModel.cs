using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace XamarinFormsEffects.Models
{
  public  class MainModel
    {
        public String Name { get; set; }
        public String Age { get; set; }
        public ICommand cmd { get; set; }
    }
}
