import { useEffect, useState } from "react"
import { getAllEducation } from "../../modules/basicManager";
import { Education } from "./Education";


export const EducationList = () => {
    const [educations, setEducation] = useState([]);

    const getEducation = () => {
        getAllEducation().then(setEducation)
    }

    useEffect(() => {
        getEducation();
    }, [])

    return (
        <>
        <h2 className="educationHeader">Education</h2>
        <div className="container">
            <div className="row justify-content-center">
                {educations.map((education) => (
                    <Education education={education} key={education.id} />
                ))}
            </div>
        </div>
        </>
    )
}