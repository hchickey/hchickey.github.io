import { Card, CardBody } from "reactstrap"
import "./basic.css"

export const Basic = ({basic}) => {
    return (
        <>
        <div className="basic">
        <Card
        color="secondary"
        >
            <CardBody>
                <div><img className="haleyImg" alt="me" src={basic.imageUrl}/></div>
                <p>A little about me... {basic.summary}</p>
                <p>You can reach me at {basic.email} or call my cell number at {basic.phone}.</p>
             </CardBody>   
        </Card>
        </div>
        </>
    )
}