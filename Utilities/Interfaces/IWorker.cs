

namespace MedocScanner.Utilities.Interfaces
{
    public interface IWorker
    {

        /// <summary>
        /// Check if the entry password is the right password for this Worker
        /// </summary>
        /// <param name="tryPassword"></param>
        /// <returns>true if password is correct</returns>
        bool IsRightPassword(string tryPassword);
    }
}
