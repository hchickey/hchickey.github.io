const baseUrl = '/api/basic';
const educationUrl = '/api/education';
const interestUrl = '/api/interest';
const socialUrl = '/api/profile';
const skillUrl = '/api/skill';
const volunteerUrl = '/api/volunteer';
const workUrl = '/api/work';

export const getAllInfo = () => {
    return fetch(baseUrl)
    .then((res) => res.json())
};

export const getAllEducation = () => {
    return fetch(educationUrl)
    .then((res) => res.json())
};

export const getAllInterest = () => {
    return fetch(interestUrl)
    .then((res) => res.json())
};

export const getAllSocials = () => {
    return fetch(socialUrl)
    .then((res) => res.json())
}

export const getAllSkill = () => {
    return fetch(skillUrl)
    .then((res) => res.json())
}

export const getAllVolunteer = () => {
    return fetch(volunteerUrl)
    .then((res) => res.json())
}

export const getAllWork = () => {
    return fetch(workUrl)
    .then((res) => res.json())
}