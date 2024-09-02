using Student.Database;

namespace Mail.Repo
{
    public class addrepo
    {
        StudentemailsysContext studentemailsysContext;

        public addrepo()
        {
            studentemailsysContext = new StudentemailsysContext();
        }

        public bool addstudent(StudentMaildetail studentMaildetail)
        {
            studentemailsysContext.StudentMaildetails.Add(studentMaildetail);
            return studentemailsysContext.SaveChanges() > 0 ? true : false;
        }
        public List<StudentMaildetail> getstudents()
        {
            {
                return studentemailsysContext.StudentMaildetails.ToList();
            }
        }
    }
}
