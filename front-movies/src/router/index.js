import Vue from 'vue'
import VueRouter from 'vue-router'
import movieInfo from '../views/movieInfo.vue'
import frontPage from '../views/frontPage.vue'
import login from '../views/login.vue'
import createdUser from '../views/createdUser.vue'


Vue.use(VueRouter)

const routes = [{
        path: '/',
        name: 'frontPage',
        component: frontPage
    },
    {
        path: '/movieInfo',
        name: 'movieInfo',
        component: movieInfo
    }, {
        path: '/createdUser',
        name: 'createdUser',
        component: createdUser

    },
    {
        path: '/login',
        name: 'login',
        component: login,
    }
]

const router = new VueRouter({
    routes
})

export default router