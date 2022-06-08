

namespace MedocScanner.Utilities.Interfaces
{
    public interface IWorker
    {


        /// <summary>
        /// Check if the entry Email from DB is the right  for this Worker
        /// </summary>
        /// <param name="email"></param>
        /// <returns>true if Email Formate is correct</returns>
        bool IsValid_Email(string email);

    }
}
