import { Link } from "react-router-dom"
import { Card, CardBody } from "reactstrap"
import './work.css'

export const Work = ({work}) => {
    return (
        <>
        <div className="work">
        <Card
        color="secondary"
        >
            <CardBody>
                <h1>{work.company}</h1>
                <p>{work.position}</p>
                <p className="link">
                    <a href= {work.website} target="_blank">View Website</a>
                </p>
                <p>{work.summary}</p>
                <footer>Start Date: {work.startDate}</footer>
                <footer>End Date: {work.endDate}</footer>
            </CardBody>
        </Card>
        <br/>
        </div>
        </>
    )
}