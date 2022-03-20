using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_schedule
{
    class GeneticAlg
    {
        int job, oper, machine, pop = 0;
        Populations[] pops;
        int length,count = 0;
        public GeneticAlg(int job, int oper, int machine, int pop)
        {
            this.job = job;
            this.oper = oper;
            this.machine = machine;
            this.pop = pop; // размер популяции 
            pops = new Populations[pop]; // популяции
            length = job * oper; 
            
        }

        //создание популяций
        private void CreatePopulation()
        {
            for (var i = 0; i < pops.Length; i++)
            {
                Populations pop = CreatePopulationsTable();
                pops[i] = pop;
                count++; 
            }
        }

        Populations CreatePopulationsTable()
        {
            var rnd = new Random(); 
            var jobTable = new int[length];
            var machineTable = new int[length];
            var assigned = new bool[length];
            var allJob = new List<int>() { };
            var delJob = new int[job];

            for (var i = 0; i < job; i++)
            {
                allJob.Add(i);
            }

            for (var i = 0; i < length; i++)
            {
                var selectedJob = allJob[rnd.Next(0, allJob.Count)];
                jobTable[i] = selectedJob;

                if (!assigned[i])
                {
                    machineTable[i] = rnd.Next(0, machine);
                }

                delJob[selectedJob]++;
                if (delJob[selectedJob] == oper)
                {
                    allJob.Remove(selectedJob); 
                }
                   
            }

            return new Populations(job, oper, machine, jobTable, machineTable);  
        }

        public void Generate()
        {
            CreatePopulation(); 
        }
    }


    // POPULATIONS
    class Populations
    {
        int popjob, popoper, popmachine = 0;
        int[] jTable, mTable; 
        public Populations(int job, int oper, int machine, int[] jTable, int[] mTable)
        {
            this.popjob = job;
            this.popoper = oper;
            this.popmachine = machine;
            this.jTable = jTable;
            this.mTable = mTable; 
        }
    }
}
