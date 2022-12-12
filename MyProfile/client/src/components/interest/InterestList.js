import { useEffect, useState } from "react"
import { getAllInterest } from "../../modules/basicManager";
import { Interest } from "./Interest";


export const InterestList = () => {
    const [interests, setInterest] = useState([]);

    const getInterest = () => {
        getAllInterest().then(setInterest)
    }

    useEffect(() => {
        getInterest();
    }, [])

    return (
        <>
        <h2 className="interestHeader">Hobbies</h2>
        <div className="container">
            <div className="row justify-content-center">
                {interests.map((interest) => (
                    <Interest interest={interest} key={interest.id} />
                ))}
            </div>
        </div>
        </>
    )
}