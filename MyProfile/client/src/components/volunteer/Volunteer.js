import { Card, CardBody } from "reactstrap"
import './volunteer.css'

export const Volunteer = ({volunteer}) => {
    return (
        <>
        <div className="volunteer">
        <Card
        color="secondary"
        >
            <CardBody>
                <h2>{volunteer.organization}</h2>
                <p>{volunteer.sumary}</p>
            </CardBody>
        </Card>
        <br/>
        </div>
        </>
    )
}