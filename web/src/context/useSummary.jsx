import { createContext, useContext, useEffect, useState } from "react"
import api from "../services/api";

const SummaryContext = createContext({});

export const SummaryProvider = ({ children }) => {
  const[pendings, setPendings] = useState(0);
  const[finalized, setFinalized] = useState(0);
  const[jobs, setJobs] = useState(0);


  useEffect(() => {
    api.get(`Process/getPending`)
    .then(response => setPendings(response.data.length));

    api.get(`Process/getFinished`)
    .then(response => setFinalized(response.data.length))

    api.get(`JobEvent/getQtdJob`)
    .then(response => setJobs(response.data));
  }, []);

  return (
    <SummaryContext.Provider value={{ pendings, finalized, jobs }}>
      {children}
    </SummaryContext.Provider>
  )
}

export function useSummary() {
  const context = useContext(SummaryContext);

  return context;
}
