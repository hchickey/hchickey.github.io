import { useEffect, useState } from "react"
import { getAllSkill } from "../../modules/basicManager"
import { Skill } from "./Skill"
import './skill.css'

export const SkillList = () => {
    const [skills, setSkill] = useState([])

    const getSkill = () => {
        getAllSkill().then(setSkill)
    }

    useEffect(() => {
        getSkill();
    }, [])

    return (
        <>
        <h2 className="skillHeader">Tech Stack</h2>
        <div className="container">
            <div className="row justify-content-center">
                {skills.map((skill) => (
                    <Skill skill={skill} key={skill.id} />
                ))}
            </div>
        </div>
        </>
    )
}