using System;
using Service.Abstractions;

namespace Service.RestApi.Models
{
    public class TaskModel
    {

        public TaskModel()
        {

        }

        public TaskModel(ImportTask task)
        {
            Id = task.ExternalId;
            AbsId = task.AbsId;
            switch (task.State)
            {
                case ImportTaskStates.Waiting:
                    State = "waiting";
                    break;
                case ImportTaskStates.Done:
                    State = "done";
                    break;
            }
        }

        public Guid Id {get;set;}

        public int AbsId {get;set;}

        public string State {get;set;} = String.Empty;

    }
}