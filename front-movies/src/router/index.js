import Vue from 'vue'
import VueRouter from 'vue-router'
import movieInfo from '../views/movieInfo.vue'
import frontPage from '../views/frontPage.vue'

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
    }
]

const router = new VueRouter({
    routes
})

export default router