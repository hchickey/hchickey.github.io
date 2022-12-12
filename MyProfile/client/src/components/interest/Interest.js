import { Card, CardBody } from "reactstrap"
import './interest.css'

export const Interest = ({interest}) => {
    return (
        <>
        <div className="interest">
        <Card
        color="secondary"
        >
            <CardBody>
                <p>{interest.hobby}</p>
            </CardBody>
        </Card>
        <br/>
        </div>
        </>
    )
}