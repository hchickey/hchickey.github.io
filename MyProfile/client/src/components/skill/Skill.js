import { Card, CardBody } from "reactstrap"
import './skill.css'

export const Skill = ({skill}) => {
    return (
        <>
        <div className="skill">
        <Card
        color="secondary"
        >
            <CardBody>
                <h2>{skill.title}</h2>
                <p>Level: {skill.level}</p>
            </CardBody>
        </Card>
        <br/>
        </div>
        </>
    )
}