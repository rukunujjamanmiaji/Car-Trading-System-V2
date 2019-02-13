﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarTradingSystem.Models
{
    public class Model
    {
        [Key]
        public int ModelID { get; set; }
        [Display(Name = "Model Name")]
        public string ModelName { get; set; }

        [ForeignKey("Brand")]
        [Display(Name = "Brand Name")]
        public int BrandID { get; set; }
        public virtual Brand Brand { get; set; }

        [Display(Name = "Year Of Release")]
        public int YearOfRelease { get; set; }

        public double Price { get; set; }

        [ForeignKey("BodyType")]
        [Display(Name = "Body Style")]
        public int BodyStyle { get; set; }
        public virtual BodyType BodyType { get; set; }

        [Display(Name = "Engine Type")]
        public string EngineType { get; set; }
        public string Displacement { get; set; }
        public string Power { get; set; }
        public string Torque { get; set; }
        public string Transmission { get; set; }
        public string DriveTrain { get; set; }
        public int NumberOfGears { get; set; }
        public int NumberofCylinders { get; set; }
        public string Performance0To100Kmph { get; set; }
        public double MaximumSpeed { get; set; }
        public double FuelTankCapacity { get; set; }


        public string BodyColor { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Wheelbase { get; set; }
        public string GrossWeight { get; set; }
        public int SeatingCapacity { get; set; }

        public string WheelType { get; set; }
        public string FrontTyreSize { get; set; }
        public string RearTyreSize { get; set; }


        public string FrontBrakeType { get; set; }
        public string RearBrakeType { get; set; }

        public string FrontSuspension { get; set; }
        public string RearSuspension { get; set; }

        public string PowerSteering { get; set; }
        public string SteeringType { get; set; }


        public bool NotAvailable { get; set; }


    }


   
}