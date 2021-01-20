using Business.DataContexts;
using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class JobSearchService : IJobSearchService
    {

        #region Create

        public void CreateApplication(Application v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.CreateApplication(v);
        }

        public void CreateApplicationType(IdName v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.CreateApplicationType(v);
        }

        public void CreateCompany(Company v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.CreateCompany(v);
        }

        public void CreateContact(Contact v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.CreateContact(v);
        }

        public void CreateContactType(IdName v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.CreateContactType(v);
        }

        public void CreateInterview(Interview v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.CreateInterview(v);
        }

        public void CreateInterviewType(IdName v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.CreateInterviewType(v);
        }

        public void CreateLocation(IdName v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.CreateLocation(v);
        }

        public void CreatePosition(IdName v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.CreatePosition(v);
        }

        public void CreatePositionType(IdName v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.CreatePositionType(v);
        }

        public void CreateRequester(IdName v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.CreateRequester(v);
        }

        public void CreateResponse(Response v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.CreateResponse(v);
        }

        public void CreateResponseType(IdName v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.CreateResponseType(v);
        }

        public void CreateResult(IdName v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.CreateResult(v);
        }

        #endregion

        #region Delete

        public void DeleteCompany(int Id)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.DeleteCompany(Id);
        }

        #endregion

        #region Edit

        public void EditApplication(Application v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.EditApplication(v);
        }

        public void EditApplicationType(IdName v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.EditApplicationType(v);
        }

        public void EditCompany(Company v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.EditCompany(v);
        }

        public void EditContact(Contact v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.EditContact(v);
        }

        public void EditContactType(IdName v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.EditContactType(v);
        }

        public void EditInterview(Interview v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.EditInterview(v);
        }

        public void EditInterviewType(IdName v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.EditInterviewType(v);
        }

        public void EditLocation(IdName v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.EditLocation(v);
        }

        public void EditPosition(IdName v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.EditPosition(v);
        }

        public void EditPositionType(IdName v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.EditPositionType(v);
        }

        public void EditRequester(IdName v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.EditRequester(v);
        }

        public void EditResponse(Response v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.EditResponse(v);
        }

        public void EditResponseType(IdName v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.EditResponseType(v);
        }

        public void EditResult(IdName v)
        {
            JobSearchDataContext j = new JobSearchDataContext();
            j.EditResult(v);
        }

        #endregion

        #region Get

        public Application GetApplication()
        {
            return new JobSearchDataContext().GetApplication();
        }

        public Application GetApplication(int Id)
        {
            return new JobSearchDataContext().GetApplication(Id);
        }

        public List<Application> GetApplications()
        {
            return new JobSearchDataContext().GetApplications();
        }

        public List<Application> GetApplications(ApplicationSearch a)
        {
            return new JobSearchDataContext().GetApplications(a);
        }

        public IdName GetApplicationType()
        {
            return new JobSearchDataContext().GetApplicationType();
        }

        public IdName GetApplicationType(int Id)
        {
            return new JobSearchDataContext().GetApplicationType(Id);
        }

        public List<IdName> GetApplicationTypes()
        {
            return new JobSearchDataContext().GetApplicationTypes();
        }

        public List<Company> GetCompanies()
        {
            return new JobSearchDataContext().GetCompanies();
        }

        public Company GetCompany()
        {
            return new JobSearchDataContext().GetCompany();
        }

        public Company GetCompany(int Id)
        {
            return new JobSearchDataContext().GetCompany(Id);
        }

        public Contact GetContact()
        {
            return new JobSearchDataContext().GetContact();
        }

        public Contact GetContact(int Id)
        {
            return new JobSearchDataContext().GetContact(Id);
        }

        public List<Contact> GetContacts()
        {
            return new JobSearchDataContext().GetContacts();
        }

        public IdName GetContactType()
        {
            return new JobSearchDataContext().GetContactType();
        }

        public IdName GetContactType(int Id)
        {
            return new JobSearchDataContext().GetContactType(Id);
        }

        public List<IdName> GetContactTypes()
        {
            return new JobSearchDataContext().GetContactTypes();
        }

        public Interview GetInterview()
        {
            return new JobSearchDataContext().GetInterview();
        }

        public Interview GetInterview(int Id)
        {
            return new JobSearchDataContext().GetInterview(Id);
        }

        public List<Interview> GetInterviews()
        {
            return new JobSearchDataContext().GetInterviews();
        }

        public List<Interview> GetInterviews(int Id)
        {
            return new JobSearchDataContext().GetInterviews(Id);
        }

        public IdName GetInterviewType()
        {
            return new JobSearchDataContext().GetInterviewType();
        }

        public IdName GetInterviewType(int Id)
        {
            return new JobSearchDataContext().GetInterviewType(Id);
        }

        public List<IdName> GetInterviewTypes()
        {
            return new JobSearchDataContext().GetInterviewTypes();
        }

        public IdName GetLocation()
        {
            return new JobSearchDataContext().GetLocation();
        }

        public IdName GetLocation(int Id)
        {
            return new JobSearchDataContext().GetLocation(Id);
        }

        public List<IdName> GetLocations()
        {
            return new JobSearchDataContext().GetLocations();
        }

        public IdName GetPosition()
        {
            return new JobSearchDataContext().GetPosition();
        }

        public IdName GetPosition(int Id)
        {
            return new JobSearchDataContext().GetPosition(Id);
        }

        public List<IdName> GetPositions()
        {
            return new JobSearchDataContext().GetPositions();
        }

        public IdName GetPositionType()
        {
            return new JobSearchDataContext().GetPositionType();
        }

        public IdName GetPositionType(int Id)
        {
            return new JobSearchDataContext().GetPositionType(Id);
        }

        public List<IdName> GetPositionTypes()
        {
            return new JobSearchDataContext().GetPositionTypes();
        }

        public IdName GetRequester()
        {
            return new JobSearchDataContext().GetRequester();
        }

        public IdName GetRequester(int Id)
        {
            return new JobSearchDataContext().GetRequester(Id);
        }

        public List<IdName> GetRequesters()
        {
            return new JobSearchDataContext().GetRequesters();
        }

        public Response GetResponse()
        {
            return new JobSearchDataContext().GetResponse();
        }

        public Response GetResponse(int Id)
        {
            return new JobSearchDataContext().GetResponse(Id);
        }

        public List<Response> GetResponses()
        {
            return new JobSearchDataContext().GetResponses();
        }

        public List<Response> GetResponses(int Id)
        {
            return new JobSearchDataContext().GetResponses(Id);
        }

        public IdName GetResponseType()
        {
            return new JobSearchDataContext().GetResponseType();
        }

        public IdName GetResponseType(int Id)
        {
            return new JobSearchDataContext().GetResponseType(Id);
        }

        public List<IdName> GetResponseTypes()
        {
            return new JobSearchDataContext().GetResponseTypes();
        }

        public IdName GetResult()
        {
            return new JobSearchDataContext().GetResult();
        }

        public IdName GetResult(int Id)
        {
            return new JobSearchDataContext().GetResult(Id);
        }

        public List<IdName> GetResults()
        {
            return new JobSearchDataContext().GetResults();
        }

        #endregion
    }
}
