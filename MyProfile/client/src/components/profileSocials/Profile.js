import { Card, CardBody } from "reactstrap"
import './social.css'

export const Profile = ({profile}) => {
    return (
        <>
        <div className="social">
        <Card
        color="secondary"
        >
            <CardBody>
            <h1>{profile.network}</h1>
            <p>User Name: {profile.userName}</p>
            <p className="socialLink">
            <a href= {profile.url} target="_blank">View Profile here</a>
            </p>
            </CardBody>
        </Card>
        <br/>
        </div>
        </>
    )
}