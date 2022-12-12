import { Card, CardBody } from "reactstrap"
import './education.css'

export const Education = ({education}) => {
    return (
        <>
        <div className="education">
        <Card
        color="secondary"
        >
            <CardBody>
                <h1>{education.school}</h1>
                <p>Study: {education.area}</p>
                <p>Type: {education.studyType}</p>
                <footer>Start Date: {education.startDate}</footer>
                <footer>End Date: {education.endDate}</footer>
            </CardBody>
        </Card>
        <br/>
        </div>
        </>
    )
}