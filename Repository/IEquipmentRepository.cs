using System;
using HendonEventsAPI.Models;

namespace HendonEventsAPI.Repository
{
	public interface IEquipmentRepository
	{
        bool DoesItemExist(string id);
        IEnumerable<Equipments> All { get; }
        Equipments Find(string id);
        void Insert(Equipments item);
        void Update(Equipments item);
        void Delete(string id);
    }
}

