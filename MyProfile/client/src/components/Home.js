import "./home.css";

export const Home = () => {
    return (
        <>
            <section className="intro" id="home">
                <h1 className="homeHeader">
                    Hi, <p className="smile">😄</p> I am <strong className="name">Haley Hickey</strong>
                </h1>

                <p className="smallIntro">Developer | Video Editor | Traveler</p>
                <img className="haleyImg" alt="me" src="/profilePic/professionalPic.jpg"/>
            </section>

            <section className="myProjects" id="projects">
                <h2 className="projectsHeader">My Projects</h2>
                <div className="projects">
                    <div className="project">
                        <h3>TN SnoSlush</h3>
                        <img className="projImg" src="/profilePic/snoSlush.png" alt="capstone"/>
                        <p>An app to help users find snowcone places in Tennessee with the best flavors, the most reviews and the closest in location to the user.</p>
                    </div>

                    <div className="project">
                        <h3>World Cuisine</h3>
                        <img className="projImg" src="/profilePic/worldCuisine.png" alt="backend capstone" />
                        <p>An app to help users find recipes from all over the world. This app is perfect for users that travel so they can find some of their favorite recipes from countries they’ve visited in the past.</p>
                    </div>
                </div>
            </section>

            <section className="about" id="aboutMe">
                <h2 className="aboutHeader">About me</h2>

                <div className="aboutBody">
                    <p>Before beginning my journey as a FullStack Web Developer, I was working as an experienced Church and Community Outreach Coordinator for a non-profit called, Raise the Roof Academy. 
                        My background comes from helping others whether it is through missionary work or nonprofits. God has always given me a heart to serve. Working in the non-profit field gave me the resources to help people and help our community. 
                        It allowed me to solve problems using logic while working with volunteers and working in a team environment. 
                        When a friend introduced me to software development, I realized that the tech field would allow me to continue my love for helping others but in a more creative way.
                    </p>
                </div>

                <img src="/profilePic/snowcone.jpg" alt="me with snowcone" className="aboutImg" />
            </section>
        </>
    )
}