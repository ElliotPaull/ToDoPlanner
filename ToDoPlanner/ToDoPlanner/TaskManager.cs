﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTask;
using ToDoPlanner;

namespace MyTask
{
    static internal class TaskManager
    {
        static public void TrackTask(string taskName, int taskPoints, ObservableCollection<MyTask> taskList)
        {
            MyTask task = new MyTask(taskName, taskPoints);
            taskList.Add(task);
        }

        static public void EditTask(string taskName, int taskPoints, MyTask task)
        {
            task.TaskName = taskName;
            task.Points = taskPoints;
        }

        static public void CompleteTask(MyTask task, DataStore data)
        {
            if (!task.Completed)
            {
                task.Completed = true;
                data.TotalPoints += task.Points;
                data.TodayPoints += task.Points;
            }
        }
    }
}
