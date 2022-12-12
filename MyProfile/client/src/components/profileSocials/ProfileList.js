import { useEffect, useState } from "react"
import { getAllSocials } from "../../modules/basicManager"
import { Profile } from "./Profile"
import './social.css'

export const ProfileList = () => {
    const [profiles, setProfile] = useState([])

    const getSocials = () => {
        getAllSocials().then(setProfile);
    }

    useEffect(() => {
        getSocials();
    }, [])

    return (
        <>
        <h2 className="socialHeader">Check out my socials!</h2>
        <div className="container">
            <div className="row justify-content-center">
                {profiles.map((profile) => (
                    <Profile profile={profile} key={profile.id} />
                ))}
            </div>
        </div>
        </>
    )
}