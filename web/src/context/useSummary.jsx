import { createContext, useCallback, useContext, useEffect, useState } from "react"
import api from "../services/api";

const SummaryContext = createContext({});

export const SummaryProvider = ({ children }) => {
  const[pendings, setPendings] = useState(0);
  const[finalized, setFinalized] = useState(0);
  const[jobs, setJobs] = useState(0);

  const loadSummary = useCallback(async () => {
    await api.get(`Process/getPending`)
    .then(response => setPendings(response.data.length));

    await api.get(`Process/getFinished`)
    .then(response => setFinalized(response.data.length))

    await api.get(`JobEvent/getQtdJob`)
    .then(response => setJobs(response.data));
  }, []);

  useEffect(() => {
    loadSummary();
  }, [loadSummary]);
  
  return (
    <SummaryContext.Provider value={{ loadSummary, pendings, finalized, jobs }}>
      {children}
    </SummaryContext.Provider>
  )
}

export function useSummary() {
  const context = useContext(SummaryContext);

  return context;
}
