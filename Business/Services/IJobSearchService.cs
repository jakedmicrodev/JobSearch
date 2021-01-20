using Business.Entities;
using System.Collections.Generic;

namespace Business.Services
{
    public interface IJobSearchService
    {

        #region Create

        void CreateApplication(Application v);

        void CreateApplicationType(IdName v);

        void CreateCompany(Company v);

        void CreateContact(Contact v);

        void CreateContactType(IdName v);

        void CreateInterview(Interview v);

        void CreateInterviewType(IdName v);

        void CreateLocation(IdName v);

        void CreatePosition(IdName v);

        void CreatePositionType(IdName v);

        void CreateRequester(IdName v);

        void CreateResponse(Response v);

        void CreateResponseType(IdName v);

        void CreateResult(IdName v);

        #endregion

        #region Delete

        void DeleteCompany(int Id);

        #endregion

        #region Edit
        void EditApplication(Application v);

        void EditApplicationType(IdName v);

        void EditCompany(Company v);

        void EditContact(Contact v);

        void EditContactType(IdName v);

        void EditInterview(Interview v);

        void EditInterviewType(IdName v);

        void EditLocation(IdName v);

        void EditPosition(IdName v);

        void EditPositionType(IdName v);

        void EditRequester(IdName v);

        void EditResponse(Response v);

        void EditResponseType(IdName v);

        void EditResult(IdName v);

        #endregion

        #region Get

        Application GetApplication();

        Application GetApplication(int Id);

        List<Application> GetApplications();

        List<Application> GetApplications(ApplicationSearch a);

        IdName GetApplicationType();

        IdName GetApplicationType(int Id);

        List<IdName> GetApplicationTypes();

        Company GetCompany();

        Company GetCompany(int Id);

        List<Company> GetCompanies();

        Contact GetContact();

        Contact GetContact(int Id);

        List<Contact> GetContacts();

        IdName GetContactType();

        IdName GetContactType(int Id);

        List<IdName> GetContactTypes();

        Interview GetInterview();

        Interview GetInterview(int Id);

        List<Interview> GetInterviews();

        IdName GetInterviewType();

        IdName GetInterviewType(int Id);

        List<IdName> GetInterviewTypes();

        IdName GetLocation();

        IdName GetLocation(int Id);

        List<IdName> GetLocations();

        IdName GetPosition();

        IdName GetPosition(int Id);

        List<IdName> GetPositions();

        IdName GetPositionType();

        IdName GetPositionType(int Id);

        List<IdName> GetPositionTypes();

        IdName GetRequester();

        IdName GetRequester(int Id);

        List<IdName> GetRequesters();

        Response GetResponse();

        Response GetResponse(int Id);

        List<Response> GetResponses();

        List<Response> GetResponses(int Id);

        IdName GetResponseType();

        IdName GetResponseType(int Id);

        List<IdName> GetResponseTypes();

        IdName GetResult();

        IdName GetResult(int Id);

        List<IdName> GetResults();

        #endregion

    }
}
