import React from "react";
import { Routes, Route } from "react-router-dom";
import { BasicList } from "./basic/BasicList";
import { Contact } from "./contact/Contact";
import { EducationList } from "./education/EducationList";
import { Home } from "./Home";
import { InterestList } from "./interest/InterestList";
import { ProfileList } from "./profileSocials/ProfileList";
import { SkillList } from "./skill/SkillList";
import { VolunteerList } from "./volunteer/VolunteerList";
import { WorkList } from "./work/WorkList";


export const ApplicationViews = () => {
    return (
        <main>
            <Routes>
                    <Route path="/" element={<Home />} />
                    <Route path="/basic" element={<BasicList />} />
                    <Route path="/education" element={<EducationList />} />
                    <Route path="/interest" element={<InterestList />} />
                    <Route path="/profile" element={<ProfileList />} />
                    <Route path="/skill" element={<SkillList />} />
                    <Route path="/volunteer" element={<VolunteerList />} />
                    <Route path="/work" element={<WorkList />} />
                    <Route path="/contact" element={<Contact />} />
                    <Route path="*" element={<p>Whoops, nothing here...</p>} />
            </Routes>
        </main>
    );
};