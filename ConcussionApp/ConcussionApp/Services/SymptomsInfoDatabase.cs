using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using System.Linq;
using ConcussionApp.Models;

namespace ConcussionApp.Services
{
    public class SymptomsInfoDatabase
        
    {
        
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static bool initialized = false;

        public SymptomsInfoDatabase()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(SymptomsInfo).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(SymptomsInfo)).ConfigureAwait(false);
                }
                initialized = true;
            }
        }

        public Task<List<SymptomsInfo>> GetSymptomsInfos()
        {
            return Database.Table<SymptomsInfo>().ToListAsync();
        }


        public Task<int> SaveSymptomsLog(SymptomsInfo log)
        {
            if (log.ID != 0)
            {
                return Database.UpdateAsync(log);
            }
            else
            {
                return Database.InsertAsync(log);
            }
        }

        public Task<int> DeleteSymptomsEval(SymptomsInfo log)
        {
            return Database.DeleteAsync(log);
        }

        public Task<List<SymptomsInfo>> OrderByScoreAsc()
        {

            
            return Database.Table<SymptomsInfo>().OrderBy(i => i.HeadacheValue).ToListAsync();
        }

        public Task<List<SymptomsInfo>> OrderByScoreDesc()
        {
            return Database.Table<SymptomsInfo>().OrderByDescending(i => i.HeadacheValue).ToListAsync();
        }

    }
}
