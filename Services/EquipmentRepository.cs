﻿using System;
using HendonEventsAPI.Models;
using HendonEventsAPI.Repository;

namespace HendonEventsAPI.Services
{
	public class EquipmentRepository : IEquipmentRepository
	{

        public List<Equipments> _equipmentList;

		public EquipmentRepository()
		{
            InitializeData();
		}

        public IEnumerable<Equipments> All
        {

            get { return _equipmentList; }
        }
        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool DoesItemExist(string id)
        {
            throw new NotImplementedException();
        }

        public Equipments Find(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Equipments item)
        {
            throw new NotImplementedException();
        }

        public void Update(Equipments item)
        {
            throw new NotImplementedException();
        }

        private void InitializeData()
        {
            _equipmentList = new List<Equipments>();

            var equipment1 = new Equipments
            {
                ID = "1",
                Name = "Product 1",
                Description = "working product 1",
                Verfied = true
            };

            var equipment2 = new Equipments
            {
                ID = "2",
                Name = "Product 2",
                Description = "working product 2",
                Verfied = true
            };

            var equipment3 = new Equipments
            {
                ID = "3",
                Name = "Product 3",
                Description = "working product 3",
                Verfied = true
            };

            _equipmentList.Add(equipment1);
            _equipmentList.Add(equipment2);
            _equipmentList.Add(equipment3);

        }
    }
}
