import { useEffect, useState } from "react"
import { getAllInfo } from "../../modules/basicManager";
import { Basic } from "./Basic";

export const BasicList = () => {
    const [basics, setBasics] = useState([]);

    const getInfo = () => {
        getAllInfo().then(setBasics);
    }

    useEffect(() => {
        getInfo();
    }, []);

    return (
        <>
        <div className="container">
            <div className="row justify-content-center">
                {basics.map((basic) => (
                    <Basic basic={basic} key={basic.id} />
                ))}
            </div>
        </div>
        </>
    )
}