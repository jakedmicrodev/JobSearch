using Business.Core;
using Business.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;

namespace Business.DataContexts
{
    public class JobSearchDataContext : IJobSearchDataContext
    {

        #region Private

        private List<SelectListItem> FillList(List<IdName> v)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (IdName c in v)
            {
                l.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString() });
            }
            return l;

        }

        private List<SelectListItem> FillList(List<IdName> v, int Id)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (IdName c in v)
            {
                l.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString(), Selected = (c.Id == Id) });
            }
            return l;

        }

        private List<SelectListItem> FillCompanies(List<Company> v)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (Company c in v)
            {
                l.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString() });
            }
            return l;
        }

        private List<SelectListItem> FillCompanies(List<Company> v, int Id)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (Company c in v)
            {
                l.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString(), Selected = (c.Id == Id) });
            }
            return l;
        }

        private List<SelectListItem> FillContacts(List<Contact> v)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (Contact c in v)
            {
                l.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString() });
            }
            return l;
        }

        private List<SelectListItem> FillContacts(List<Contact> v, int Id)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (Contact c in v)
            {
                l.Add(new SelectListItem { Text = c.Name, Value = c.Id.ToString(), Selected = (c.Id == Id) });
            }
            return l;
        }

        private List<SelectListItem> FillResponses(List<Response> v)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (Response c in v)
            {
                l.Add(new SelectListItem { Text = c.Result, Value = c.Id.ToString() });
            }
            return l;
        }

        private List<SelectListItem> FillResponses(List<Response> v, int Id)
        {
            List<SelectListItem> l = new List<SelectListItem>();

            foreach (Response c in v)
            {
                l.Add(new SelectListItem { Text = c.Result, Value = c.Id.ToString(), Selected = (c.Id == Id) });
            }
            return l;
        }

        #endregion

        #region Create

        public void CreateApplication(Application v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@CompanyId", v.CompanyId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@PositionId", v.PositionId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@PositionTypeId", v.PositionTypeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@PositionNumber", v.PositionNumber == null ? string.Empty : v.PositionNumber, DbType.String, ParameterDirection.Input, v.PositionNumber == null ? 0 : v.PositionNumber.Length);
            parameters.Add("@PayRate", v.PayRate == null ? string.Empty : v.PayRate, DbType.String, ParameterDirection.Input, v.PayRate == null ? 0 : v.PayRate.Length);
            parameters.Add("@Requirements", v.Requirements, DbType.String, ParameterDirection.Input, v.Requirements.Length);
            parameters.Add("@LocationId", v.LocationId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@RequesterId", v.RequesterId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ApplicationTypeId", v.ApplicationTypeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ContactId", v.ContactId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ResponseTypeId", v.ResponseTypeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ResultId", v.ResultId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@SubmitDate", v.SubmitDate, DbType.DateTime, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEAPPLICATION, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateApplicationType(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEAPPLICATIONTYPE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateCompany(Company v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);
            parameters.Add("@Website", v.Website, DbType.String, ParameterDirection.Input, v.Website.Length);
            parameters.Add("@IsRecruiter", v.IsRecruiter, DbType.Boolean, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.CREATECOMPANY, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateContact(Contact v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);
            parameters.Add("@CompanyId", v.CompanyId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ContactTypeId", v.ContactTypeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Phone", v.Phone == null ? string.Empty : v.Phone, DbType.String, ParameterDirection.Input, v.Phone == null ? 0 : v.Phone.Length);
            parameters.Add("@Email", v.Email == null ? string.Empty : v.Email, DbType.String, ParameterDirection.Input, v.Email == null ? 0 : v.Email.Length);

            try {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.CREATECONTACT, parameters, commandType: CommandType.StoredProcedure);
            }
            } catch(Exception e)
            {
                Console.Write(e.Message);
            }
        }

        public void CreateContactType(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.CREATECONTACTTYPE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateInterview(Interview v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@ApplicationId", v.ApplicationId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@CompanyId", v.CompanyId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@InterviewDate", v.InterviewDate, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("@InterviewTypeId", v.InterviewTypeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Notes", v.Notes == null ? string.Empty : v.Notes, DbType.String, ParameterDirection.Input, v.Notes == null ? 0 : v.Notes.Length);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEINTERVIEW, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateInterviewType(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEINTERVIEWTYPE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateLocation(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.CREATELOCATION, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreatePosition(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEPOSITION, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreatePositionType(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEPOSITIONTYPE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateRequester(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.CREATEREQUESTER, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateResponse(Response v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@ApplicationId", v.ApplicationId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ResponseTypeId", v.ResponseTypeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ResponseDate", v.ResponseDate, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("@ResultId", v.ResultId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ContactId", v.ContactId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Notes", v.Notes == null ? string.Empty : v.Notes, DbType.String, ParameterDirection.Input, v.Notes == null ? 0 : v.Notes.Length);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.CREATERESPONSE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateResponseType(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.CREATERESPONSETYPE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateResult(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.CREATERESULT, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region Delete

        public void DeleteCompany(int Id)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.DELETECOMPANY, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region Edit

        public void EditApplication(Application v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@CompanyId", v.CompanyId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@PositionId", v.PositionId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@PositionTypeId", v.PositionTypeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@PositionNumber", v.PositionNumber == null ? string.Empty : v.PositionNumber, DbType.String, ParameterDirection.Input, v.PositionNumber == null ? 0 : v.PositionNumber.Length);
            parameters.Add("@PayRate", v.PayRate == null ? string.Empty : v.PayRate, DbType.String, ParameterDirection.Input, v.PayRate == null ? 0 : v.PayRate.Length);
            parameters.Add("@Requirements", v.Requirements, DbType.String, ParameterDirection.Input, v.Requirements.Length);
            parameters.Add("@LocationId", v.LocationId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@RequesterId", v.RequesterId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ApplicationTypeId", v.ApplicationTypeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ContactId", v.ContactId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ResponseTypeId", v.ResponseTypeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ResultId", v.ResultId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@SubmitDate", v.SubmitDate, DbType.DateTime, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEAPPLICATION, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditApplicationType(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEAPPLICATIONTYPE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditCompany(Company v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);
            parameters.Add("@Website", v.Website, DbType.String, ParameterDirection.Input, v.Website.Length);
            parameters.Add("@IsRecruiter", v.IsRecruiter, DbType.Boolean, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATECOMPANY, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditContact(Contact v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);
            parameters.Add("@CompanyId", v.CompanyId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ContactTypeId", v.ContactTypeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Phone", v.Phone == null ? string.Empty : v.Phone, DbType.String, ParameterDirection.Input, v.Phone == null ? 0 : v.Phone.Length);
            parameters.Add("@Email", v.Email == null ? string.Empty : v.Email, DbType.String, ParameterDirection.Input, v.Email == null ? 0 : v.Email.Length);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATECONTACT, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditContactType(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATECONTACTTYPE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditInterview(Interview v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@CompanyId", v.CompanyId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@InterviewDate", v.InterviewDate, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("@InterviewTypeId", v.InterviewTypeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Notes", v.Notes == null ? string.Empty : v.Notes, DbType.String, ParameterDirection.Input, v.Notes == null ? 0 : v.Notes.Length);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEINTERVIEW, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditInterviewType(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEINTERVIEWTYPE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditLocation(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATELOCATION, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditPosition(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEPOSITION, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditPositionType(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEPOSITIONTYPE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditRequester(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATEREQUESTER, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditResponse(Response v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ResponseTypeId", v.ResponseTypeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ResponseDate", v.ResponseDate, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("@ResultId", v.ResultId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@ContactId", v.ContactId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Notes", v.Notes == null ? string.Empty : v.Notes, DbType.String, ParameterDirection.Input, v.Notes == null ? 0 : v.Notes.Length);

            try
            { 
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATERESPONSE, parameters, commandType: CommandType.StoredProcedure);
            }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void EditResponseType(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATERESPONSETYPE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditResult(IdName v)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Id", v.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", v.Name, DbType.String, ParameterDirection.Input, v.Name.Length);

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                conn.Execute(StoredProcedures.UPDATERESULT, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region Get

        public Application GetApplication()
        {
            Application a = new Application();

            a.Companies = FillCompanies(GetCompanies());
            a.Positions = FillList(GetPositions());
            a.PositionTypes = FillList(GetPositionTypes());
            a.Locations = FillList(GetLocations());
            a.Requesters = FillList(GetRequesters());
            a.ApplicationTypes = FillList(GetApplicationTypes());
            a.Contacts = FillContacts(GetContacts());
            a.Responses = FillList(GetResponseTypes());
            a.Results = FillList(GetResults());

            return a;
        }

        public Application GetApplication(int Id)
        {
            Application a = null;

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                a = conn.QueryFirst<Application>(StoredProcedures.GETAPPLICATIONS + " @Id", parameters);
            }

            a.Companies = FillCompanies(GetCompanies(), a.CompanyId);
            a.Positions = FillList(GetPositions(), a.PositionId);
            a.PositionTypes = FillList(GetPositionTypes(), a.PositionTypeId);
            a.Locations = FillList(GetLocations(), a.LocationId);
            a.Requesters = FillList(GetRequesters(), a.RequesterId);
            a.ApplicationTypes = FillList(GetApplicationTypes(), a.ApplicationTypeId);
            a.Contacts = FillContacts(GetContacts(), a.ContactId);
            a.Responses = FillList(GetResponseTypes(), a.ResponseTypeId);
            a.Results = FillList(GetResults(), a.ResultId);

            return a;
        }

        public List<Application> GetApplications()
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                return conn.Query<Application>(StoredProcedures.GETAPPLICATIONS).ToList<Application>();
            }
        }

        public List<Application> GetApplications(ApplicationSearch a)
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                var parameters = new DynamicParameters();
                string sql = null;
                var isValid = false;

                if (a.CompanyId > 0)
                {
                    sql = string.Format(StoredProcedures.GETAPPLICATIONS + " @Id, @CompanyId");
                    parameters.Add("@Id", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@CompanyId", a.CompanyId, DbType.Int32, ParameterDirection.Input);
                    isValid = true;
                }
                else if (a.ContactId > 0)
                {
                    sql = string.Format(StoredProcedures.GETAPPLICATIONS + " @Id, @CompanyId, @PositionId, @PositionTypeId, @PositionNumber, @PayRate, @Requirements, @LocationId, @RequesterId, @ApplicationTypeId, @ContactId");
                    parameters.Add("@Id", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@CompanyId", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@PositionId", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@PositionTypeId", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@PositionNumber", null, DbType.String, ParameterDirection.Input);
                    parameters.Add("@PayRate", null, DbType.String, ParameterDirection.Input);
                    parameters.Add("@Requirements", null, DbType.String, ParameterDirection.Input);
                    parameters.Add("@LocationId", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@RequesterId", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@ApplicationTypeId", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@ContactId", a.ContactId, DbType.Int32, ParameterDirection.Input);
                    isValid = true;
                }
                else if (a.RequesterId > 0)
                {
                    sql = string.Format(StoredProcedures.GETAPPLICATIONS + " @Id, @CompanyId, @PositionId, @PositionTypeId, @PositionNumber, @PayRate, @Requirements, @LocationId, @RequesterId");
                    parameters.Add("@Id", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@CompanyId", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@PositionId", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@PositionTypeId", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@PositionNumber", null, DbType.String, ParameterDirection.Input);
                    parameters.Add("@PayRate", null, DbType.String, ParameterDirection.Input);
                    parameters.Add("@Requirements", null, DbType.String, ParameterDirection.Input);
                    parameters.Add("@LocationId", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@RequesterId", a.RequesterId, DbType.Int32, ParameterDirection.Input);
                    isValid = true;
                }
                else if (!string.IsNullOrEmpty(a.PositionNumber))
                {
                    sql = string.Format(StoredProcedures.GETAPPLICATIONS + " @Id, @CompanyId, @PositionId, @PositionTypeId, @PositionNumber");
                    parameters.Add("@Id", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@CompanyId", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@PositionId", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@PositionTypeId", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@PositionNumber", a.PositionNumber, DbType.String, ParameterDirection.Input, a.PositionNumber.Length);
                    isValid = true;
                }
                else if (a.StartDate != null && a.EndDate != null)
                {
                    sql = string.Format(StoredProcedures.GETAPPLICATIONS + " @Id, @CompanyId, @PositionId, @PositionTypeId, @PositionNumber, @PayRate, @Requirements, @LocationId, @RequesterId, @ApplicationTypeId, @ContactId, @ResponseTypeId, @ResultId, @StartDate, @EndDate");
                    parameters.Add("@Id", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@CompanyId", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@PositionId", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@PositionTypeId", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@PositionNumber", null, DbType.String, ParameterDirection.Input);
                    parameters.Add("@PayRate", null, DbType.String, ParameterDirection.Input);
                    parameters.Add("@Requirements", null, DbType.String, ParameterDirection.Input);
                    parameters.Add("@LocationId", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@RequesterId", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@ApplicationTypeId", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@ContactId", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@ResponseTypeId", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@ResultId", null, DbType.Int32, ParameterDirection.Input);
                    parameters.Add("@StartDate", a.StartDate, DbType.DateTime, ParameterDirection.Input);
                    parameters.Add("@EndDate", a.EndDate, DbType.DateTime, ParameterDirection.Input);
                    isValid = true;
                }

                if (!isValid)
                {
                    return null;
                }
                else
                {
                    return conn.Query<Application>(sql, parameters).ToList<Application>();
                }
            }
        }

        public IdName GetApplicationType()
        {
            return new IdName();
        }

        public IdName GetApplicationType(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirst<IdName>(StoredProcedures.GETAPPLICATIONTYPES + " @Id", parameters);
            }
        }

        public List<IdName> GetApplicationTypes()
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                return conn.Query<IdName>(StoredProcedures.GETAPPLICATIONTYPES).ToList<IdName>();
            }
        }

        public List<Company> GetCompanies()
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                return conn.Query<Company>(StoredProcedures.GETCOMPANIES).ToList<Company>();
            }
        }

        public Company GetCompany()
        {
            return new Company();
        }

        public Company GetCompany(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirst<Company>(StoredProcedures.GETCOMPANIES + " @Id", parameters);
            }
        }

        public Contact GetContact()
        {
            Contact c = new Contact();

            c.Companies = FillCompanies(GetCompanies());
            c.ContactTypes = FillList(GetContactTypes());

            return c;
        }

        public Contact GetContact(int Id)
        {
            Contact c = null;

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                c = conn.QueryFirst<Contact>(StoredProcedures.GETCONTACTS + " @Id", parameters);
            }

            c.Companies = FillCompanies(GetCompanies(), c.CompanyId);
            c.ContactTypes = FillList(GetContactTypes(), c.ContactTypeId);

            return c;
        }

        public List<Contact> GetContacts()
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                return conn.Query<Contact>(StoredProcedures.GETCONTACTS).ToList<Contact>();
            }
        }

        public IdName GetContactType()
        {
            return new IdName();
        }

        public IdName GetContactType(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirst<IdName>(StoredProcedures.GETCONTACTTYPES + " @Id", parameters);
            }
        }

        public List<IdName> GetContactTypes()
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                return conn.Query<IdName>(StoredProcedures.GETCONTACTTYPES).ToList<IdName>();
            }
        }

        public Interview GetInterview()
        {
            Interview i = new Interview();

            i.Companies = FillCompanies(GetCompanies());
            i.InterviewTypes = FillList(GetInterviewTypes());

            return i;
        }

        public Interview GetInterview(int Id)
        {
            Interview i = null;

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                i = conn.QueryFirst<Interview>(StoredProcedures.GETINTERVIEWS + " @Id", parameters);
            }

            i.Companies = FillCompanies(GetCompanies(), i.CompanyId);
            i.InterviewTypes = FillList(GetInterviewTypes(), i.InterviewTypeId);

            return i;
        }

        public List<Interview> GetInterviews()
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                return conn.Query<Interview>(StoredProcedures.GETINTERVIEWS).ToList<Interview>();
            }
        }

        public List<Interview> GetInterviews(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                var parameters = new DynamicParameters();
                var sql = string.Format("{0} {1}", StoredProcedures.GETINTERVIEWS, "@Id, @ApplicationId");

                parameters.Add("@Id", null, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@ApplicationId", Id, DbType.Int32, ParameterDirection.Input);
                return conn.Query<Interview>(sql, parameters).ToList<Interview>();
            }
        }

        public IdName GetInterviewType()
        {
            return new IdName();
        }

        public IdName GetInterviewType(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirst<IdName>(StoredProcedures.GETINTERVIEWTYPES + " @Id", parameters);
            }
        }

        public List<IdName> GetInterviewTypes()
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                return conn.Query<IdName>(StoredProcedures.GETINTERVIEWTYPES).ToList<IdName>();
            }
        }

        public IdName GetLocation()
        {
            return new IdName();
        }

        public IdName GetLocation(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirst<IdName>(StoredProcedures.GETLOCATIONS + " @Id", parameters);
            }
        }

        public List<IdName> GetLocations()
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                return conn.Query<IdName>(StoredProcedures.GETLOCATIONS).ToList<IdName>();
            }
        }

        public IdName GetPosition()
        {
            return new IdName();
        }

        public IdName GetPosition(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirst<IdName>(StoredProcedures.GETPOSITIONS + " @Id", parameters);
            }
        }

        public List<IdName> GetPositions()
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                return conn.Query<IdName>(StoredProcedures.GETPOSITIONS).ToList<IdName>();
            }
        }

        public IdName GetPositionType()
        {
            return new IdName();
        }

        public IdName GetPositionType(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirst<IdName>(StoredProcedures.GETPOSITIONTYPES + " @Id", parameters);
            }
        }

        public List<IdName> GetPositionTypes()
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                return conn.Query<IdName>(StoredProcedures.GETPOSITIONTYPES).ToList<IdName>();
            }
        }

        public IdName GetRequester()
        {
            return new IdName();
        }

        public IdName GetRequester(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirst<IdName>(StoredProcedures.GETREQUESTERS + " @Id", parameters);
            }
        }

        public List<IdName> GetRequesters()
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                return conn.Query<IdName>(StoredProcedures.GETREQUESTERS).ToList<IdName>();
            }
        }

        public Response GetResponse()
        {
            Response r = new Response();

            r.ResponseTypes = FillList(GetResponseTypes());
            r.Results = FillList(GetResults());
            r.Contacts = FillContacts(GetContacts());

            return r;
        }

        public Response GetResponse(int Id)
        {
            Response r = null;

            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                r = conn.QueryFirst<Response>(StoredProcedures.GETRESPONSES + " @Id", parameters);
            }

            r.ResponseTypes = FillList(GetResponseTypes(), r.ResponseTypeId);
            r.Results = FillList(GetResults(), r.ResultId);
            r.Contacts = FillContacts(GetContacts(), r.ContactId);

            return r;
        }

        public List<Response> GetResponses()
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                return conn.Query<Response>(StoredProcedures.GETRESPONSES).ToList<Response>();
            }
        }

        public List<Response> GetResponses(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                var parameters = new DynamicParameters();
                var sql = string.Format("{0} {1}", StoredProcedures.GETRESPONSES, "@Id, @ApplicationId");

                parameters.Add("@Id", null, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@ApplicationId", Id, DbType.Int32, ParameterDirection.Input);
                return conn.Query<Response>(sql, parameters).ToList<Response>();
            }
        }

        public IdName GetResponseType()
        {
            return new IdName();
        }

        public IdName GetResponseType(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirst<IdName>(StoredProcedures.GETRESPONSETYPES + " @Id", parameters);
            }
        }

        public List<IdName> GetResponseTypes()
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                return conn.Query<IdName>(StoredProcedures.GETRESPONSETYPES).ToList<IdName>();
            }
        }

        public IdName GetResult()
        {
            return new IdName();
        }

        public IdName GetResult(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", Id, DbType.Int32, ParameterDirection.Input);
                return conn.QueryFirst<IdName>(StoredProcedures.GETRESULTS + " @Id", parameters);
            }
        }

        public List<IdName> GetResults()
        {
            using (IDbConnection conn = new SqlConnection(Settings.JobSearchConnectionString))
            {
                return conn.Query<IdName>(StoredProcedures.GETRESULTS).ToList<IdName>();
            }
        }

        #endregion

    }
}
