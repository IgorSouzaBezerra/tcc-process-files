import { useState, useEffect } from 'react';

function usePersistedState(key, initialState) {
    const[state, setState] = useState(() => {
        const storegeValue = localStorage.getItem(key);

        if (storegeValue) {
            return JSON.parse(storegeValue);
        } else {
            return initialState;
        }
    });

    useEffect(() => {
        localStorage.setItem(key, JSON.stringify(state))
    }, [key, state]);

    return [state, setState];
}

export default usePersistedState;
