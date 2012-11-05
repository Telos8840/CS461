using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestGame
{
    class Task
    {
	public enum Tasks
	{
	   initilize;
	   priorty;
	   go;
	   stop;
	   
	}
	private Tasks _currentTask;
	public Tasks currentTask
	{
	    get
            { 
                return _currentTask; 
            }
            set 
            {
                _currentstate = value; 
            }
        }

        public TaskManager()
        {
            _currentTask = Tasks.initilize;
        }
    }
		

    }
}