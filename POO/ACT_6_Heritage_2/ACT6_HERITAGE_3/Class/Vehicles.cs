using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT6_HERITAGE_3.Class
{
    internal abstract class Vehicle
    {
        protected string _marque;
        protected float _fuel;

        public Vehicle(string marque, float fuel)
        {
            _marque = marque;
            _fuel = fuel;
        }

        public string Marque
        {
            get => _marque;
            set => _marque = value;
        }

        public float Fuel
        {
            get => _fuel;
            set => _fuel = value;
        }

        public abstract string Infos();
    }
    internal abstract class RoadVehicle : Vehicle
    {
        protected float _kilometrage;

        public RoadVehicle(string marque, float fuel, float kilometrage) : base(marque, fuel)
        {
            _kilometrage = kilometrage;
        }

        public float Kilometrage
        {
            get => _kilometrage;
            set => _kilometrage = value;
        }
    }
    internal class Car : RoadVehicle
    {
        public Car(string marque, float fuel, float kilometrage) : base(marque, fuel, kilometrage)
        {
        }

        public override string Infos()
        {
            return $"Voiture : {_marque}, {_fuel}L de carburant, {_kilometrage} km";
        }
    }
    internal class Truck : RoadVehicle
    {
        private int _maxWeight;

        public Truck(string marque, float fuel, float kilometrage, int maxWeight) : base(marque, fuel, kilometrage)
        {
            _maxWeight = maxWeight;
        }

        public int MaxWeight
        {
            get => _maxWeight;
            set => _maxWeight = value;
        }

        public override string Infos()
        {
            return $"Camion : {_marque}, {_fuel}L de carburant, {_kilometrage} km, {_maxWeight} kg max";
        }
    }
    internal class Boat : Vehicle
    {
        private int _tonnage;

        public Boat(string marque, float fuel, int tonnage) : base(marque, fuel)
        {
            _tonnage = tonnage;
        }

        public int Tonnage => _tonnage;

        public override string Infos()
        {
            return $"Bateau : {_marque}, {_fuel}L de carburant, {_tonnage} tonnes";
        }
    }
    internal class Plane : Vehicle
    {
        private int _distMax;

        public Plane(string marque, float fuel, int distMax) : base(marque, fuel)
        {
            _distMax = distMax;
        }

        public int DistMax => _distMax;

        public override string Infos()
        {
            return $"Avion : {_marque}, {_fuel}L de carburant, {_distMax} km max";
        }
    }
}
