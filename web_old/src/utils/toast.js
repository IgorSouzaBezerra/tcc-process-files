import { toast } from 'react-toastify';

export function Error(message) {
    return toast.error(message, {
        position: "bottom-left"
    });
}

export function Info(message) {
    return toast.info(message, {
        position: "bottom-left"
    });
}

export function Sucess(message) {
    return toast.success(message, {
        position: "bottom-left"
    });
}
