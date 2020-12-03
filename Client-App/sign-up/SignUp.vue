<template>
  <div class="sign-up">
    <form class="sign-up__form">
      <h3>sign up for yourself or a friend!</h3>
      <input v-model="form.user" type="text" name="user" id="user" placeholder="Username" />

      <div class="sign-up__titles">
        <div v-for="(title, index) in titles" :key="title.value">
          <input
            v-model="form.title"
            type="radio"
            name="title"
            :id="`title${index}`"
            :value="title.value"
          />
          <label :for="`title${index}`">{{ title.value }}</label>
        </div>
      </div>

      <input v-model="form.pass" type="password" name="pass" id="pass" placeholder="Password" />
      <input
        v-model="form.firstName"
        type="text"
        name="first-name"
        id="first-name"
        placeholder="First Name"
      />
      <input v-model="form.email" type="email" name="email" id="email" placeholder="Email" />
      <input
        v-model="form.lastName"
        type="text"
        name="last-name"
        id="last-name"
        placeholder="Last Name"
      />
      <input v-model="form.pic" type="url" name="pic" id="pic" placeholder="Picture URL" />
      <textarea v-model="form.bio" name="bio" id="bio" cols="30" rows="5" placeholder="Biography" />
      <input
        v-model="form.org"
        type="text"
        name="industry"
        id="industry"
        placeholder="Industry/Organization"
      />
      <input
        v-model="form.git"
        type="text"
        name="git-hub"
        id="git-hub"
        placeholder="GitHub Username"
      />
      <input
        v-model="form.linkedIn"
        type="url"
        name="linked-in"
        id="linked-in"
        placeholder="LinkedIn URL"
      />

      <Multiselect
        v-model="form.skills"
        :options="skills"
        :multiple="true"
        label="name"
        placeholder="Skills"
        track-by="name"
        class="sign-up__m-select"
      />

      <Multiselect
        v-model="form.courses"
        :options="courses"
        :multiple="true"
        label="courseNumber"
        track-by="courseNumber"
        placeholder="Courses"
        class="sign-up__m-select"
      >
        <template slot="singleLabel" slot-scope="props">
          <span>{{ props.option.courseNumber }}</span>
        </template>

        <template slot="option" slot-scope="props">
          <span>{{ props.option.courseNumber }} - {{ props.option.courseName }}</span>
        </template>
      </Multiselect>

      <input type="button" value="Cancel" @click="$emit('close')" />
      <input type="button" value="Submit" @click="submitHandler" />
    </form>
  </div>
</template>

<script>
import Axios from 'axios';
import FormData from 'form-data';
import Multiselect from 'vue-multiselect';

export default {
  components: {
    Multiselect,
  },

  data() {
    return {
      courses: [],
      skills: [],
      titles: [],
      nonRequiredInputs: ['bio', 'git', 'linkedIn', 'org', 'pic'],
      form: {
        user: null,
        pass: null,
        email: null,
        title: null,
        firstName: null,
        lastName: null,
        pic: null,
        bio: null,
        org: null,
        git: null,
        linkedIn: null,
        skills: null,
        courses: null,
      },
    };
  },

  created() {
    Axios.get('courses').then(res => (this.courses = res.data));
    Axios.get('skills').then(res => (this.skills = res.data));
    Axios.get('titles').then(res => (this.titles = res.data));
  },

  methods: {
    addUser() {
      const userForm = new FormData();
      userForm.append('name', this.form.user);
      userForm.append('email', this.form.email);

      Axios.post('users/add', userForm, { headers: userForm.getHeaders })
        .catch(err => {
          if (err.response.status === 409) {
            window.alert('User already exists!');
          }
        })
        .then(res => {
          if (!res) {
            return;
          }
          this.addProfile(res.data);
        });
    },

    addProfile(user) {
      Axios.post('profiles/add', {
        title: this.form.title,
        firstName: this.form.firstName,
        lastName: this.form.lastName,
        email: this.form.email,
        gitHub: this.form.git,
        linkedIn: this.form.linkedIn,
        organization: this.form.org,
        biography: this.form.bio,
        picture: this.form.pic,
        courses: this.form.courses.map(c => c.courseNumber),
        skills: this.form.skills.map(s => s.name),
      })
        .catch(err => {
          if (err.response.status === 409) {
            window.alert('Error adding profile!');
          }
        })
        .then(res => {
          if (!res) {
            return;
          }

          window.alert('Profile added!');
          this.$emit('close');
        });
    },

    submitHandler() {
      const formKeys = Object.keys(this.form);

      for (let i = 0; i < formKeys.length; ++i) {
        const key = formKeys[i];
        if (this.nonRequiredInputs.includes(key)) {
          continue;
        }

        if (!this.form[key]) {
          window.alert(
            'All fields required except: Biography, GitHub, LinkedIn, Organization and Picture!'
          );
          return;
        }
      }

      this.addUser();
    },
  },
};
</script>

<style>
@import 'vue-multiselect/dist/vue-multiselect.min.css';

.sign-up {
  background-color: #444;
  border: 0.125rem solid #fff;
  border-radius: 0.5rem;
  padding: 1rem;
}

.sign-up input {
  font-size: 1.2rem;
  padding: 0.3rem;
}

.sign-up input[type='button'] {
  cursor: pointer;
}

.sign-up input[type='button']:hover {
  border-color: aqua;
}

.sign-up textarea {
  background-color: #999;
  border: 0.125rem solid #fff;
  font-size: 1.2rem;
  font-weight: 500;
  padding: 0.3rem;
}

.sign-up textarea:focus {
  outline: none;
}

.sign-up__form {
  column-gap: 1.5rem;
  display: grid;
  grid-template-columns: 1fr 1fr;
  row-gap: 1.5rem;
}

.sign-up__form > h3 {
  grid-column: span 2;
  text-align: right;
  text-transform: uppercase;
  width: 100%;
}

.sign-up__form > #bio {
  grid-row: span 2;
}

.sign-up__titles {
  align-items: center;
  display: flex;
}

.sign-up__titles > div {
  margin-right: 1rem;
}

.sign-up__m-select {
  grid-column: span 2;
  grid-row: span 2;
}

.multiselect__tags {
  background: #999;
  border: 0.125rem solid #fff;
}

.multiselect__placeholder {
  color: #444;
  font-size: 1rem;
  font-weight: 500;
  padding: 0;
}

.multiselect__select::before {
  border-color: #444 transparent transparent;
  color: #444;
}
</style>
