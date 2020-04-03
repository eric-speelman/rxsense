using System;
using System.Collections.Generic;
using System.Text;

namespace RxSense.DrugCache
{
    /*This interface represents an in process cache.
     * Load will be called at app startup and performance is not critical.
     * Assume we have ample memory
     * GetByNdc, GetByPartialNdc and GetStrengthsByPartialNdc are performance sensitive.
     * */
    public interface IDrugCache
    {
        void Load(string path);

        //Returns all drugs that match the given ndc exactly (exculding whitespace)
        IEnumerable<Drug> GetByNdc(string ndc);

        //Returns all drugs that start with the given ndc (exclusing whitespace)
        IEnumerable<Drug> GetByPartialNdc(string partialNdc);

        //Returns a dictionary where each key is an ndc that matches one or more of the partial ndcs given and each value is a list of available drug strengths.
        IDictionary<string, IEnumerable<Drug>> GetStrengthsByPartialNdc (IEnumerable<string> partialNdcs);
    }
}
