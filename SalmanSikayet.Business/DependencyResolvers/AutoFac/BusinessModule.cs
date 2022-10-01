using Autofac;
using AutoMapper;
using SalmanSikayet.Business.Abstract;
using SalmanSikayet.Business.Concrete;
using SalmanSikayet.Business.Insfrastructure.AutoMapper;
using SalmanSikayet.DataAccess.Abstract;
using SalmanSikayet.DataAccess.Concrete;
using SalmanSikayet.DataAccess.Concrete.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmanSikayet.Business.DependencyResolvers.AutoFac
{
    public class BusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ComplaintManager>().As<IComplaintService>();
            builder.RegisterType<ComplaintDal>().As<IComplaintDal>();
            builder.RegisterType<SalmanSikayetContext>().SingleInstance();


            base.Load(builder);
        }
    }
}
